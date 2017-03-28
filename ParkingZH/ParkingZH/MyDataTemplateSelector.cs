using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParkingZH
{
    class MyDataTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        private readonly DataTemplate parkingDataTemplate;

        public MyDataTemplateSelector()
        {
            // Retain instances!
            this.parkingDataTemplate= new DataTemplate(typeof(ParkingViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var parkingVm = item as ParkingViewModel;
            if (parkingVm == null)
                return null;
            return this.parkingDataTemplate;
        }


    }
}
