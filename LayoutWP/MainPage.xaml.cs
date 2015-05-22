using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LayoutWP.Resources;

namespace LayoutWP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnL1G_Click(object sender, RoutedEventArgs e)
        {
            Uri newPage = new Uri("/Layout1_Grid.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        private void btnL2G_Click(object sender, RoutedEventArgs e)
        {
            Uri newPage = new Uri("/Layout2_Grid.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        private void btnL3G_Click(object sender, RoutedEventArgs e)
        {
            Uri newPage = new Uri("/Layout3_Grid.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        private void btnL1S_Click(object sender, RoutedEventArgs e)
        {
            Uri newPage = new Uri("/Layout1_Stack.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        private void btnL2S_Click(object sender, RoutedEventArgs e)
        {
            Uri newPage = new Uri("/Layout2_Stack.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        private void btnL3S_Click(object sender, RoutedEventArgs e)
        {
            Uri newPage = new Uri("/Layout3_Stack.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}