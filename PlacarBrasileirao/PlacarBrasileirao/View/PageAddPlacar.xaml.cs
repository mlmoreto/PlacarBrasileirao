
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
    public partial class PageAddPlacar : ContentPage
    {
        public PageAddPlacar()
        {
            InitializeComponent();
        }

        // Salva o Placar capturando os dados informados na tela de ADD PLACAR
        private void OnSavePlacar(object sender, EventArgs args)
        {

            /*var p = new Placar
            {                
                NroRodada = pckRodada.SelectedItem.ToString(),
                Time1 = pckTime1.SelectedItem.ToString(),
                GolTime1 = pckGolTime1.SelectedItem.ToString(),
                Time2 = pckTime2.SelectedItem.ToString(),
                GolTime2 = pckGolTime2.SelectedItem.ToString()
            }*/

            Placar p = BindingContext as Placar;
            App.Database.SaveItemAsync(p);
            Navigation.PopAsync();
        }

        private void OnDeletePlacar(object sender, EventArgs args)
        {
            Placar p = BindingContext as Placar;
            App.Database.DeleteItemAsync(p);
            Navigation.PopAsync();
        }
    }
}