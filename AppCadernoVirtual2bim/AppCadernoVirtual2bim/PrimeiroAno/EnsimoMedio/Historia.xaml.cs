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
    public partial class Historia : ContentPage
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void Historia1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Historia1());
        }

        private void Historia2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Historia2());
        }

        private void Historia3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Historia3());
        }
    }
}