using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//using nos da o acesso à diferentes diretórios, que serão utilizados posteriormente para a Navegação de Páginas

using AppCadernoVirtual2bim.PrimeiroAno.EnsimoMedio.Materias;
using AppCadernoVirtual2bim.SegundoAno.EnsinoMedio;
using AppCadernoVirtual2bim.TerceiroAno.EnsinoMedio;

namespace AppCadernoVirtual2bim.PrimeiroAno.EnsimoMedio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Biologia : ContentPage
    {
        public Biologia()
        {
            InitializeComponent();
        }

        private void Biologia1_Clicked(object sender, EventArgs e)
        {
            //Navegação: foi definido como ação do botão, a navegação entre telas
            // Nela, podemos escolher entre PushAsync e PopAsync, denso, respectivamente, o envio de uma nova página 
            //para um conjunto de navegação e a retirada da pãgina mais recente em um conjunto de navegação

            Navigation.PushAsync(new Biologia1());
        }

        private void Biologia2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Biologia2());
        }

        private void Biologia3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Biologia3());
        }
    }
}