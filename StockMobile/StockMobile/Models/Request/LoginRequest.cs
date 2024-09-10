namespace StockMobile.Models.Request
{
    public class LoginRequest
    {
        public LoginRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;

    }
}
