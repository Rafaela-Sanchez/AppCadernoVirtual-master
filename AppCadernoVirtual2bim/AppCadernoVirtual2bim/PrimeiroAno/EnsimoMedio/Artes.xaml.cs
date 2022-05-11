using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCadernoVirtual2bim.PrimeiroAno.EnsimoMedio.Materias;

namespace AppCadernoVirtual2bim.PrimeiroAno.EnsimoMedio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Artes : ContentPage
    {
        public Artes()
        {
            InitializeComponent();
        }

        private void Artes1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Artes1());
        }
    }
}