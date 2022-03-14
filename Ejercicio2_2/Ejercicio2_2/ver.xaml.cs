using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio2_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ver : ContentPage
    {
        public ver(byte[] paso)
        {
            InitializeComponent();

            byte[] image = (byte[]) paso;
            ImageSource imageSource = null;
            imageSource = ImageSource.FromStream(() => new MemoryStream(image));

            firma.Source = imageSource;

        }
    }
}