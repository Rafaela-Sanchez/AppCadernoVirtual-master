using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCadernoVirtual2bim.PrimeiroAno.EnsimoMedio.Materias;
using AppCadernoVirtual2bim.SegundoAno.EnsinoMedio;
using AppCadernoVirtual2bim.TerceiroAno.EnsinoMedio;

namespace AppCadernoVirtual2bim.PrimeiroAno.EnsimoMedio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ingles : ContentPage
    {
        public Ingles()
        {
            InitializeComponent();
        }

        private void Ingles1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingles1());
        }

        private void Ingles2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingles2());
        }

        private void Ingles3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingles3());
        }
    }
}