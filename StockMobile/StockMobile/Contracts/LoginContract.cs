using Flunt.Validations;
using StockMobile.Models.Request;
using System.Diagnostics.Contracts;

namespace StockMobile.Contracts
{

    public class LoginContract : Contract<LoginRequest>
    {
        public LoginContract(LoginRequest request)
        {
            Requires()
                .IsNotNullOrEmpty(request.Email, "Email", "Email is required")
                .IsEmail(request.Email, "Email", "Email invalid")
                .IsNullOrEmpty(request.Password, "Senha", "Password cant be null");
        }
    }
}
