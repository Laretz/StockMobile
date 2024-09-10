using Flurl;
using Flurl.Http;
using StockMobile.Helpers;
using StockMobile.Models.Request;
using StockMobile.Models.Response;

namespace StockMobile.Repositories.Login
{
    internal class LoginRepository : ILoginRepository
    {

        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var response = await Constants.ApiUrl
                .AppendPathSegment("/users/login")
                .PutJsonAsync(loginRequest);

            if (response.ResponseMessage.IsSuccessStatusCode)
            {
                var content = await response.ResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<LoginResponse>(content);
            }

            return new LoginResponse();
        }
    }
}

