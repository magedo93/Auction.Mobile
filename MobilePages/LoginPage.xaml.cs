using System;

using Xamarin.Forms;

namespace Auction.Mobile.MobilePages
{
    public partial class LoginPage : ContentPage
    {
		public LoginPage ()
		{
			InitializeComponent ();
		}

        public void LoginButtonClicked(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new MasterPage());
            //await Navigation.PushAsync(new MainMenuPage());
            Application.Current.MainPage = new MasterPage();
        }
    }
}
