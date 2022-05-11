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
    public partial class Geografia : ContentPage
    {
        public Geografia()
        {
            InitializeComponent();
        }

        private void Geografia1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Geografia1());
        }

        private void Geografia2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Geografia2());
        }

        private void Geografia3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Geografia3());
        }
    }
}