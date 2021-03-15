using MyBeerApp.ViewModel;
using Xamarin.Forms;

namespace MyBeerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new BeerViewModel();
            if (Device.RuntimePlatform == Device.Android)
            {
                NavigationPage.SetHasNavigationBar(this, false);

            }
        }

        async void ListOfBeers_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var beer = (Beer)e.Item;
            await Navigation.PushAsync(new BeerDetailPage());
        }

    }
}
