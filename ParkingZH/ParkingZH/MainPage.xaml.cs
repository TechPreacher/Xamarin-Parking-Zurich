using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ParkingZH
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Parkings in Zürich";
            BindingContext = new MainPageViewModel();
           
        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Device.OpenUri(new Uri(((ParkingViewModel)ParkingsListView.SelectedItem).Url));
            //ParkingsListView.SelectedItem = null;
        }

        private void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Device.OpenUri(new Uri(((ParkingViewModel)ParkingsListView.SelectedItem).Url));
            //ParkingsListView.SelectedItem = null;
        }
    }
}
