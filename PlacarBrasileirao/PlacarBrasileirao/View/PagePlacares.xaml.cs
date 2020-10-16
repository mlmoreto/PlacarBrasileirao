using PlacarBrasileirao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlacarBrasileirao.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePlacar : ContentPage
    {
        public PagePlacar()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }
        private async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAddPlacar());
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new PageAddPlacar()
                {
                    BindingContext = args.SelectedItem as Placar
                });
            }
        }

    }
}