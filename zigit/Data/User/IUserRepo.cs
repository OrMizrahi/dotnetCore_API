using zigit.Models;

namespace zigit.Data
{
    public interface IUserRepo
    {
        public string Login(string email, string password);
        public User GetUserByEmail(string email);
    }
}
