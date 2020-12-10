using System.Linq;
using zigit.Data.Auth;
using zigit.Models;

namespace zigit.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly UserContext _context;
        private readonly IAuthenticationManager _authManagaer;

        public SqlUserRepo(UserContext context, IAuthenticationManager authManager)
        {
            _context = context;
            _authManagaer = authManager;
        }

        public string Login(string email, string password)
        {
            if (!_context.Users.Any(u => u.Email == email && u.Password == password))
                return null;

            return _authManagaer.GenerateToken(email);
        }

        public User GetUserByEmail(string email)
        {
           return _context.Users.FirstOrDefault(u=>u.Email == email);
        }
    }
}
