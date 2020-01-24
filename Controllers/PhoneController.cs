using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;
namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone


        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone{
                    PhoneName ="Samsung Note 9",
                    MSRP = 3453,
                    ScreenSize = 2,
                    DateReleased = new DateTime(2018,08,23),
                    Manufacturer = "Samsung"
                },
                new Phone{
                    PhoneName ="Samsung Galaxy s9",
                    MSRP = 4356.65,
                    ScreenSize = 6,
                    DateReleased = new DateTime(2018,03,16),
                    Manufacturer = "Samsung"
                },
                new Phone{
                    PhoneName ="iPhone 11 Pro",
                    MSRP = 3700.00,
                    ScreenSize = 2,
                    DateReleased = new DateTime(2019,09,20),
                    Manufacturer = "Apple"
                },
                new Phone{
                    PhoneName ="Google pixel 2",
                    MSRP = 1375,
                    ScreenSize = 5,
                    DateReleased = new DateTime(2017,08,10),
                    Manufacturer = "Google"
                }
                };

          
            return View(phoneList);


        }
        //phoneList.Add("Charger"),
        //    phoneList.Add("Adapter"),
        //    phoneList.Add("USB"),
        //    phoneList.Add("Earplugs")
    }
}