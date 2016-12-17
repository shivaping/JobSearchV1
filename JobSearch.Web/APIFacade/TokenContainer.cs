namespace JobSearch.Web.APIFacade
{
    using System.Web;
    using JobSearch.APIHelper;

    public class TokenContainer : ITokenContainer
    {
        private const string ApiTokenKey = "ApiToken";
        private const string UserNameKey = "UserName";
        public object ApiToken
        {
            get { return Current.Session != null ? Current.Session[ApiTokenKey] : null; }
            set { if (Current.Session != null) Current.Session[ApiTokenKey] = value; }
        }

        public string UserName
        {
            get { return Current.Session != null && Current.Session[UserNameKey] != null ? Current.Session[UserNameKey].ToString() : null; }
            set { if (Current.Session != null) Current.Session[UserNameKey] = value; }
        }
        private static HttpContextBase Current
        {
            get { return new HttpContextWrapper(HttpContext.Current); }
        }
    }
}