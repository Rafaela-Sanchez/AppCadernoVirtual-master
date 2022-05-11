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
    public partial class Fisica : ContentPage
    {
        public Fisica()
        {
            InitializeComponent();
        }

        private void Fisica1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fisica1());
        }

        private void Fisica2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fisica2());
        }

        private void Fisica3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fisica3());
        }
    }
}