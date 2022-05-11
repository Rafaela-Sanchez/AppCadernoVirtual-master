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
    public partial class Matematica : ContentPage
    {
        public Matematica()
        {
            InitializeComponent();
        }

        private void BtnMatematica1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Matematica1());
        }

        private void BtnMatematica2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Matematica2());
        }

        private void BtnMatematica3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Matematica3());
        }
    }
}