using JwtAuth.Models;

namespace JwtAuth.Services
{
    public interface IJwtService
    {
        Task<string> GetTokenAsync(AuthRequest authRequest);
    }
}
