using DAL;

namespace BLL.Services
{
    public static class AuthService
    {
        public static dynamic Authenticate(string email, string pass) {
            var token=  DataAccessFactory.AuthDataAccess().Authenticate(email, pass);
            return token;
        }
        public static bool ValidateToken(string key)
        {
            var token = DataAccessFactory.TokenDataAccess().Get(key);
            if (token !=null && token.ExpireDate == null) return true;
            return false;

        }
    }
}