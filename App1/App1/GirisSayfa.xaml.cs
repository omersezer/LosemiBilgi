using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisSayfa : ContentPage
    {
        public GirisSayfa()
        {
            InitializeComponent();
        }

        private void buttonLosemiNedir_Clicked(object sender, EventArgs e)
        {
            NavigationPage sayfa = new NavigationPage(new LosemiNedirSayfa());
            sayfa.BarBackgroundColor = Color.Blue;
            Navigation.PushModalAsync(sayfa);
        }

        private void buttonLosemiBelirtileri_Clicked(object sender, EventArgs e)
        {
            NavigationPage sayfa = new NavigationPage(new LosemiBelirtileriSayfa());
            sayfa.BarBackgroundColor = Color.Blue;
            Navigation.PushModalAsync(sayfa);
        }

        private void buttonTedavi_Clicked(object sender, EventArgs e)
        {
            NavigationPage sayfa = new NavigationPage(new TedaviYontemleriSayfa());
            sayfa.BarBackgroundColor = Color.Blue;
            Navigation.PushModalAsync(sayfa);

        }

        private void buttonUnlu_Clicked(object sender, EventArgs e)
        {

        }

        private void buttonDestekOl_Clicked(object sender, EventArgs e)
        {
            NavigationPage sayfa = new NavigationPage(new DestekOlSayfa());
            sayfa.BarBackgroundColor = Color.Blue;
            Navigation.PushModalAsync(sayfa);
        }

        private void buttonBeslenme_Clicked(object sender, EventArgs e)
        {
            NavigationPage sayfa = new NavigationPage(new Beslenme());
            sayfa.BarBackgroundColor = Color.Blue;
            Navigation.PushModalAsync(sayfa);
        }

        private void buttonSavasiKazananlar_Clicked(object sender, EventArgs e)
        {
            NavigationPage sayfa = new NavigationPage(new SavasiKazananSayfa());
            sayfa.BarBackgroundColor = Color.Blue;
            Navigation.PushModalAsync(sayfa);
        }
    }
}