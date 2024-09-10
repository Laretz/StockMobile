using CommunityToolkit.Maui.Alerts;
using StockMobile.Contracts;
using StockMobile.Models.Request;
using StockMobile.Repositories.Login;
using System.Text;

namespace StockMobile.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
       
        public LoginViewModel(ILoginRepository loginRepository)
        {
            _loginRepostiory = loginRepository;
        }
        private readonly ILoginRepository _loginRepostiory;

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        [RelayCommand]
        public async Task Login()
        {
            var loginRequest = new LoginRequest(Email, Password);

            var contract = new LoginContract(loginRequest);

            if (!contract.IsValid)
            {
                var messages = contract.Notifications.Select(x => x.Message);
                var sb = new StringBuilder();

                foreach (var message in messages)
                    sb.Append($"{message}\n");

                await Shell.Current.DisplayAlert("Atention", sb.ToString(), "OK");
                return;
            }


            var result = await _loginRepostiory.LoginAsync(loginRequest);

            if (result is null || string.IsNullOrEmpty(result.acessToken))
            {
                var toast = Toast.Make("Login failed, try again latter", CommunityToolkit.Maui.Core.ToastDuration.Long);
                await toast.Show();
            }

        }

    }
}
