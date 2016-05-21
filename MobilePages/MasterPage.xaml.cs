
using Auction.Mobile.ViewModels;
using System;
using Xamarin.Forms;

namespace Auction.Mobile.MobilePages
{
    public partial class MasterPage : MasterDetailPage
	{
        MainMenuPage mainmenu;
		public MasterPage ()
		{
			InitializeComponent ();
            mainmenu = new MainMenuPage();
            Master = mainmenu;
            mainmenu.ListView.ItemSelected += OnItemSelected;
            Detail = new NavigationPage(new HomePage());

		}

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainMenuPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                mainmenu.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
