using Auction.Mobile.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Auction.Mobile.MobilePages
{
    public partial class MainMenuPage : ContentPage
	{
        public ListView ListView { get { return listView; } }

        public MainMenuPage ()
		{
			InitializeComponent ();

            var masterPageItems = new List<MainMenuPageItem>();
            masterPageItems.Add(new MainMenuPageItem
            {
                Title = "Home",
                IconSource = "contacts.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MainMenuPageItem
            {
                Title = "User Profile",
                IconSource = "Profile.png",
                TargetType = typeof(UserProfilePage)
            });
            masterPageItems.Add(new MainMenuPageItem
            {
                Title = "Settings",
                IconSource = "reminders.png",
                TargetType = typeof(ApplicationSettingsPage)
            });
            masterPageItems.Add(new MainMenuPageItem
            {
                Title = "About",
                IconSource = "reminders.png",
                TargetType = typeof(ApplicationSettingsPage)
            });
            listView.ItemsSource = masterPageItems;
          //  ListView.ItemsSource = masterPageItems;
            
        }
	}
}
