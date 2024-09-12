
using Flurl;
using Flurl.Http;
using StockMobile.Helpers;
using StockMobile.Models.Request;

namespace StockMobile.Repositories.SignUp
{
    public class SignUpRepository : ISignUpRepository
    {
        public async Task<bool> CreateAsync(SignupRequest request)
        {
           

                var response = await Constants.ApiUrl
                .AppendPathSegment("/users")
                .PostJsonAsync(request);

            return response.ResponseMessage.IsSuccessStatusCode;
        }
    }
}
