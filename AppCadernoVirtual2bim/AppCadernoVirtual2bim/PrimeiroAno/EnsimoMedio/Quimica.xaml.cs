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
    public partial class Quimica : ContentPage
    {
        public Quimica()
        {
            InitializeComponent();
        }

        private void Quimica1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Quimica1());

        }

        private void Quimica2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Quimica2());

        }

        private void Quimica3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Quimica3());

        }
    }
}