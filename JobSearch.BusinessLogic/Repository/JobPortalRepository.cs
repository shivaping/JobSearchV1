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
    public interface IRepository<T>

    {

        T GetById(int id);

        IQueryable<T> GetAll();

        void Edit(T entity);

        void Insert(T entity);

        void Delete(T entity);

    }
    public class Repository<T> : IRepository<T> where T : class
    {

        public DbContext context;
        public DbSet<T> dbset;
        public Repository(DbContext context)
        {
            this.context = context;
            this.context.Configuration.LazyLoadingEnabled = false;
            this.context.Configuration.ProxyCreationEnabled = false;
            dbset = context.Set<T>();
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }


        public IQueryable<T> GetAll()
        {
            return dbset;
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);
        }


        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }


        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

    }
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Job> StudentRepository { get; }
        void Save();
    }


    public partial class UnitOfWork : IUnitOfWork
    {
        private IRepository<Job> _studentRepository;
        private JobPortalContext _context;
        public IRepository<Job> StudentRepository
        {
            get
            {

                if (_studentRepository == null)
                    _studentRepository = new Repository<Job>(_context);
                return _studentRepository;
            }
        }


        public UnitOfWork()
        {
            _context = new JobPortalContext();
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
    /*
    public interface IJobPortalRepository
    {
        UserDetail GetUserDetail(string userID);
        bool SaveUserDetails(UserDetail user);
    }
    public class JobPortalRepository : IJobPortalRepository
    {
        private JobPortalContext context;
        public JobPortalRepository(JobPortalContext context)
        {
            this.context = context;
            this.context.Configuration.ProxyCreationEnabled = false;
        }

        public UserDetail GetUserDetail(string userID)
        {
            UserDetail returnValue = context.UserDetails.Find(userID);
            context.Entry(returnValue).Collection(p => p.UserProfiles).Load();
            //context.UserDetails.Include("UserDetail.UserResumes");
            //context.Entry(UserDetail).Reference(p=>p.)
          
            return returnValue;
        }

        public bool SaveUserDetails(UserDetail user)
        {
            bool returnValue = false;
            using (System.Data.Entity.DbContextTransaction dbTran = context.Database.BeginTransaction())
            {
                try
                {
                    context.UserDetails.Add(user);
                    context.SaveChanges();

                    dbTran.Commit();
                }
                catch (Exception)
                {
                    returnValue = false;
                    dbTran.Rollback();
                    throw;
                }
            }
            return returnValue;
        }
    }

    public interface IUnitOfWork
    {
        IJobPortalRepository IRepository { get; }
        void Save();
    }

    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        readonly JobPortalContext _context = new JobPortalContext();
        IJobPortalRepository _IJobPortalRepository;
        public IJobPortalRepository IRepository
        {
            get { return _IJobPortalRepository ?? (_IJobPortalRepository = new JobPortalRepository(_context)); }
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
        void IUnitOfWork.Save()
        {
            _context.SaveChanges();
        }
    }*/
}
