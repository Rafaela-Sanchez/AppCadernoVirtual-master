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
    public partial class Portugues : ContentPage
    {
        public Portugues()
        {
            InitializeComponent();
        }

        private void Portugues1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Portugues1());
        }

        private void Portugues2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Portugues2());
        }

        private void Portugues3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Portugues3());
        }
    }
}