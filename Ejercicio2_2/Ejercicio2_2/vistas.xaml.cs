using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio2_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vistas : ContentPage
    {
        public vistas()
        {
            InitializeComponent();
        }

        async private void ListaFirma_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Modelos.claseConstructor item = (Modelos.claseConstructor)e.Item;
            var newpage = new ver(item.arreglo);
            newpage.BindingContext = item;
            await Navigation.PushAsync(newpage);

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            ListaFirma.ItemsSource = await App.BaseDatos.listaFirmas();
        }

    }
}