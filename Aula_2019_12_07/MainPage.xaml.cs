using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula_2019_12_07
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public Command LogarCommand { get; set; }

        public MainPage()
        {
            BindingContext = this;

            Email = "leandro@lanceloti.com.br";
            Senha = "123123";

            LogarCommand = new Command(Logar);

            InitializeComponent();

            //Email.Text = "leandro@lanceloti.com.br";
            //Email.BackgroundColor = Color.Red;
            //Email.TextColor = Color.FromHex("fff");
        }

        async void Logar()
        {
            if (!string.IsNullOrEmpty(Email) && Email.ToLower() == "leandro@lanceloti.com.br" && !string.IsNullOrEmpty(Senha) && Senha == "123123")
            {
                Application.Current.MainPage = new NavigationPage(new Anuncios());
            }
            else
            {
                await DisplayAlert("Erro...", "Dados inválidos!", "Ok");
            }
        }
    }
}
