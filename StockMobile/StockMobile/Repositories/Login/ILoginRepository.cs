using StockMobile.Models.Request;
using StockMobile.Models.Response;

namespace StockMobile.Repositories.Login
{
    public interface ILoginRepository
    {
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
    }
}
