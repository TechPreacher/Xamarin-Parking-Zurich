using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingZH
{
    public class ParkingViewModel : BaseViewModel
    {
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; RaisePropertyChanged(); }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; RaisePropertyChanged(); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;  RaisePropertyChanged();}
        }

        private string status;

        public string Status    
        {
            get { return status; }
            set { status = value; RaisePropertyChanged();}
        }

        private string available;

        public string Available
        {
            get { return available; }
            set { available = value; RaisePropertyChanged(); }
        }
    }
}
