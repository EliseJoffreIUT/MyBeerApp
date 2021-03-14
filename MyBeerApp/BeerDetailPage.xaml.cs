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
            NavigationPage.SetIconColor(this, Color.FromHex("#ec9d00"));
        }
    }
}
