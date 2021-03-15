using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyBeerApp
{
    public partial class BeerDetailPage : ContentPage
    {
        public BeerDetailPage()
        {
            InitializeComponent();

            // Customisation de la barre de navigation
            if(Device.RuntimePlatform == Device.Android)
            {
                ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ec9d00");
                ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
                NavigationPage.SetIconColor(this, Color.White);
            }
            else
            {
                ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.White;
                ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.FromHex("#ec9d00");
                NavigationPage.SetIconColor(this, Color.FromHex("#ec9d00"));
            }

            
        }
    }
}
