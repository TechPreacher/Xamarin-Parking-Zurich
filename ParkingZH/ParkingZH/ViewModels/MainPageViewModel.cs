using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using Xamarin.Forms;


namespace ParkingZH
{
    public class MainPageViewModel : BaseViewModel
    {

        private ObservableCollection<ParkingViewModel> parkingsList;

        public ObservableCollection<ParkingViewModel> Parkings
        {
            get { return parkingsList; }
            set { parkingsList = value; RaisePropertyChanged(); }
        }

        public ICommand RefreshCommand { get; set; }

        public MainPageViewModel()
        {
            LoadParkings();

            RefreshCommand = new Command(() =>
            {
                LoadParkings();
            });
        }

        private async void LoadParkings()
        {
            // Load the RSS file from the RSS URL
            //var xDoc = XDocument.Load(@"http://www.pls-zh.ch/plsFeed/rss");


            var client = new HttpClient();
            var stream = await client.GetStreamAsync("http://www.pls-zh.ch/plsFeed/rss");
            var xDoc = XDocument.Load(stream);

            // Parse the Items in the RSS file
            var ParkingsLoaded = from item in xDoc.Descendants("item")
                select new ParkingViewModel

                // Iterate through the items in the RSS file
                {
                    Url = item.Element("link").Value,
                    Image = "http://www.plszh.ch/images/parkhaus/img_" + item.Element("link").Value.Substring(item.Element("link").Value.IndexOf("pid=") + 4)+".jpg",
                    Name = item.Element("title").Value.Substring(0, item.Element("title").Value.IndexOf(" / ", 0)).Trim(),
                    Status = item.Element("description").Value.Substring(0, item.Element("description").Value.IndexOf(" / ", 0)).Trim(),
                    Available = item.Element("description").Value.Substring(item.Element("description").Value.IndexOf(" / ", 0) + 3).Trim()
                };

            this.Parkings = new ObservableCollection<ParkingViewModel>(ParkingsLoaded);
        }

    }
}
