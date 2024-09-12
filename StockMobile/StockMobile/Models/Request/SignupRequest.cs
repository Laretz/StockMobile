namespace StockMobile.Models.Request
{
    public class SignupRequest
    {
        public SignupRequest(string name, string email, string password)
        {
            UserId = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
        }

        public Guid UserId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
