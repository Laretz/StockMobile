using CommunityToolkit.Maui.Alerts;
using StockMobile.Models.Request;
using StockMobile.Repositories.SignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMobile.ViewModels
{
    public partial class SignUpViewModel : BaseViewModel
    {
        private readonly ISignUpRepository _signUpRepository;
        public SignUpViewModel(ISignUpRepository signUpRepository)
        {
            _signUpRepository = signUpRepository;
        }
        [ObservableProperty]
        string name;

        [ObservableProperty]
        string password;

        [ObservableProperty]
        string email;

        [RelayCommand]
        public async Task Signup()
        { 
            var request = new SignupRequest(Name, Email, Password);
            // validações

            var result = await _signUpRepository.CreateAsync(request);

            if (result)
            {
                var toast = Toast.Make("Usuario cadastrado com sucesso!", CommunityToolkit.Maui.Core.ToastDuration.Long);
                await toast.Show();

                await Shell.Current.GoToAsync("..");
            }
            else
            {
                var toast = Toast.Make("Erro ao cadastrar o usuario", CommunityToolkit.Maui.Core.ToastDuration.Long);
                await toast.Show();

                
            }
        }
    }
}
