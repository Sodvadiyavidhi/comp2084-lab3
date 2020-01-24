using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            DateReleased = DateTime.Now;
            PhoneName = "";
            Manufacturer = "";
            
        }

        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public double MSRP { get; set; }
        public int ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }
    }
}