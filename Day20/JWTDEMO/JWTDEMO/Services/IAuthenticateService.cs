using JWTDEMO.Models;

namespace JWTDEMO.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string userName, string passwrod);
    }
}
