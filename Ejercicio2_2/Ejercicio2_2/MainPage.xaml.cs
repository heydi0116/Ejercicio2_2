using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Ejercicio2_2.Modelos;
using System.IO;
using SignaturePad.Forms;

namespace Ejercicio2_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnVer_Clicked(object sender, EventArgs e)
        {
            var newpage = new vistas();
            await Navigation.PushAsync(newpage);


        }

        async private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Stream image_ = await vistaFirma.GetImageStreamAsync(SignatureImageFormat.Jpeg);

            BinaryReader br = new BinaryReader(image_);

            br.BaseStream.Position = 0;

            Byte[] All = br.ReadBytes((int)image_.Length);


            var emple = new claseConstructor
            {
                nombre = txtNombre.Text,
                descripcion = txtDescripcion.Text,
                arreglo = (byte[])All
            };

            var resultado = await App.BaseDatos.EmpleadoGuardar(emple);
            if (resultado != 0){
                await DisplayAlert("Completado", "Guardado", "Seguir");
                txtNombre.Text = "";
                txtDescripcion.Text = "";
            }
            else{
                await DisplayAlert("Error", "No Completado", "Seguir");
            }


        }
    }
}
