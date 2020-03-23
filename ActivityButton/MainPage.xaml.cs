using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActivityButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewPage()));
        }
    }
}
