using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PlacarBrasileirao.ViewModel
{
    class MainPageViewModel
    {

        public MainPageViewModel()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://globoesporte.globo.com/futebol/brasileirao-serie-a/"));
        }

        public ICommand OpenWebCommand { get; }
    }

    
}
