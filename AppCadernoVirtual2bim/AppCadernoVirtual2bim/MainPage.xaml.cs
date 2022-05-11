using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppCadernoVirtual2bim.PrimeiroAno.EnsimoMedio;
using AppCadernoVirtual2bim.PrimeiroAno.EnsinoTecnico;


namespace AppCadernoVirtual2bim
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Ensino Médio 

            BtnMatematica.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Matematica.jpg");
            BtnPortugues.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Portugues.jpg");
            BtnHistoria.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Historia.jpg");
            BtnFisica.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Fisica.jpg");
            BtnQuimica.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Quimica.jpg");
            BtnBiologia.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Biologia.jpg");
            BtnGeografia.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Geografia.jpg");
            BtnSociologia.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Sociologia.jpg");
            BtnFilosofia.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Filosofia.jpg");
            BtnArtes.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Artes.jpg");
            BtnIngles.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.Ingles.jpg");

            //Ensino Técnico 
            BtnBancoDados.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.BancoDados.png");
            BtnAnaliseProj.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.AnaliseProjeto.jpg");
            BtnDesignDigital.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.DesignDigital.jpg");
            BtnFundamentosInfo.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.FundamentosInfo.jpg");
            BtnProgramacaoAlg.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.ProgramacaoAlg.jpg");
            ProgramacaoWeb.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.ProgramacaoWeb.jpg");
            ProgramacaoMobile.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.ProgMobile.jpg");
            DesenvolvimentoSist.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.DesenvolvimentoSist.jpg");
            EticaCidad.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.EticaCidadania.jpg");
            SistemasEmbarcados.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.SistemasEmb.jpg");
            QualidadeSoft.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.QualidadeSoft.jpg");
            InternetRedes.Source = ImageSource.FromResource("AppCadernoVirtual2bim.Capas.InternetRedes.jpg");
        }

        private void BotaoMatematica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Matematica());
        }

        private void BotaoPortugues(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Portugues());
        }

        private void BotaoHistoria(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Historia());
        }

        private void BotaoFisica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fisica());
        }

        private void BotaoQuimica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Quimica());
        }

        private void BotaoBiologia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Biologia());
        }

        private void BotaoGeografia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Geografia());
        }

        private void BotaoSociologia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sociologia());
        }

        private void BotaoFilosofia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Filosofia());
        }

        private void BotaoArtes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Artes());
        }

       private void BotaoIngles(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingles());
        }

        private void BtnBancoDados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BancoDeDados1());
        }

        private void BtnAnaliseProj_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnaliseProjeto());
        }

        private void BtnDesignDigital_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesignDigital());
        }

        private void BtnFundamentosInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FundamentosInfo());
        }

        private void BtnProgramacaoAlg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgramacaoAlg());
        }

        private void ProgramacaoWeb_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgramacaoWeb1());
        }

        private void ProgramacaoMobile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgramacaoMobile1());
        }

        private void DesenvolvimentoSist_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesenvolvimentoSist());
        }

        private void EticaCidad_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EticaCidadania());
        }

        private void SistemasEmbarcados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SistemasEmbarcados());
        }

        private void QualidadeSoft_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QualidadeSoftware());
        }

        private void InternetRedes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InternetRedes());
        }
    }
}
