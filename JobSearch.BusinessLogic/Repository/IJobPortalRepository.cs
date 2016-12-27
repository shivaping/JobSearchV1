using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSearch.DataAcccess.Models;
using System.Linq.Expressions;
using System.Data.Entity;

namespace JobSearch.BusinessLogic.Repository
{
    public interface IJobPortalRepository
    {
        UserDetail GetUserDetail(string userID);
        bool SaveUserDetails(UserDetail user);
    }
    public interface IDbFactory : IDisposable
    {
        JobPortalContext Init();
    }
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        // Ovveride this to dispose custom objects
        protected virtual void DisposeCore()
        {
        }
    }
    public class DbFactory : Disposable, IDbFactory
    {
        JobPortalContext dbContext;

        public JobPortalContext Init()
        {
            return dbContext ?? (dbContext = new JobPortalContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        void Add(T entity);
        // Marks an entity as modified
        void Update(T entity);
        // Marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        // Get an entity by int id
        T GetById(int id);
        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);
        // Gets all entities of type T
        IEnumerable<T> GetAll();
        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
    public interface IUnitOfWork
    {
        void Commit();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private JobPortalContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public JobPortalContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
    public interface IPortalRepository : IRepository<UserDetail>
    {
        UserDetail GetUserDetail(string userID);
    }
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private JobPortalContext dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected JobPortalContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        #endregion

    }
    public class PortalRepository : RepositoryBase<UserDetail>, IPortalRepository
    {
        public PortalRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public UserDetail GetUserDetail(string userID)
        {
            var userDetail = this.DbContext.UserDetails.Where(c => c.UserID == userID).FirstOrDefault();

            return userDetail;
        }

    }
}
