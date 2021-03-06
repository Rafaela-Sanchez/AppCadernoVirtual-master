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
    public partial class Sociologia : ContentPage
    {
        public Sociologia()
        {
            InitializeComponent();
        }

        private void Filosofia3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sociologia2());
        }

        private void Filosofia2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sociologia3());
        }
    }
}