using PlacarBrasileirao.Model;
using PlacarBrasileirao.View;
using System;
using Xamarin.Forms;

namespace PlacarBrasileirao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {            
            InitializeComponent();            
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePlacar());
        }

    }
}
