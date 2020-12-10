
namespace zigit.Data.Auth
{
    public interface IAuthenticationManager
    {
        string GenerateToken(string email);
    }
}
