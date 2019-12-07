using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula_2019_12_07
{
    public partial class Anuncios : ContentPage
    {
        public Command PopupCommand { get; set; }
        public Command NavegarCommand { get; set; }
        public Anuncios()
        {
            BindingContext = this;

            NavegarCommand = new Command(Navegar);
            PopupCommand = new Command(PopUp);

            InitializeComponent();
        }

        async void Navegar()
        {
            Navigation.PushAsync(new ContentPage() { Title = "Página 2" });
        }

        async void PopUp()
        {
            Navigation.PushModalAsync(new ContentPage() { Title = "PopUp" });
        }
    }
}
