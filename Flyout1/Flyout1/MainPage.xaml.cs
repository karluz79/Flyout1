using Flyout1.Resources;
using System;
using Xamarin.Forms;

namespace Flyout1
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            flyoutPage.listView.ItemSelected += OnItemSelected;
            Detail = new NavigationPage(new Views.DoorPage()) { BarBackgroundColor = Color.FromHex("#212836"), BarTextColor = Color.FromHex("#FFFFFF") };
            flyoutPage.listView.SelectedItem = null;
            IsPresented = false;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType)) { BarBackgroundColor = Color.FromHex("#212836"), BarTextColor = Color.FromHex("#FFFFFF") };
                flyoutPage.listView.SelectedItem = null;

                IsPresented = false;
            }
            else
            {
                IsPresented = false;
            }
        }
    }
}
