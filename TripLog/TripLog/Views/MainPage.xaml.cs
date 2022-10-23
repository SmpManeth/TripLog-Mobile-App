using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripLog.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var items = new List<TripLogEntry>
            {
                new TripLogEntry
                {
                    Title="Washinton Monument",
                    Notes = "Amazing!",
                    Rating = 3,
                    Date = new DateTime(2022,2,5),
                    Latitude = 38.8895,
                    Longitude = -77.0352
                },
                new TripLogEntry
                {
                    Title="Golden Gate Bridge",
                    Notes = "Foggy, But Beautiful.",
                    Rating = 5,
                    Date = new DateTime(2022,4,26),
                    Latitude = 37.8895,
                    Longitude = -122.0352
                },
                new TripLogEntry
                {
                    Title="Statue Of liberty",
                    Notes = "Inspiring!",
                    Rating = 4,
                    Date = new DateTime(2022,8,12),
                    Latitude = 40.8895,
                    Longitude = -74.0352
                }
            };
            trips.ItemsSource = items;
        }
        void New_Clicked(object sender , EventArgs e)
        {
            Navigation.PushAsync(new NewEntryPage());
        }
    }
}