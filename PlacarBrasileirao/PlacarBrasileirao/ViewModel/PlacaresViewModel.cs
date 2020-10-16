using PlacarBrasileirao.Model;
using PlacarBrasileirao.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PlacarBrasileirao.ViewModel
{
    public class PlacaresViewModel : ContentPage
    {
       // public Command AddItemCommand { get; }

        public PlacaresViewModel()
        {
        //    AddItemCommand = new Command(OnAddItem);
        }

       /* private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(PageAddPlacar));
        }*/

        private async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAddPlacar());
        }

        /*async void OnItemSelected(Placar item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
            //await Shell.Current.GoToAsync($"{nameof(PageAddPlacar)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }*/
    }
}