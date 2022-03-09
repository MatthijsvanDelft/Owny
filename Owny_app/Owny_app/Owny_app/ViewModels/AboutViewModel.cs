using System;
using Owny_app.Views;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Owny_app.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            LogoutCommand = new Command(OnLogoutClicked);
        }

        public ICommand OpenWebCommand { get; }
        public Command LogoutCommand { get; }

        private async void OnLogoutClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}