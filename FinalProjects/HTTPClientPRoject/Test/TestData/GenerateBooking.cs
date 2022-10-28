using HttpClientProject.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClientProject.Helpers;
using HTTPClientPRoject.DataModels;

namespace HttpClientProject.Test.TestData
{
    //GenerateBooking
    public class GenerateBookingRecord
    {
        public static BookingModel bookingInstance()
        {
            TestDataH testDataHelper = new TestDataH();
            Bookingdates bookingdates = new Bookingdates();
            bookingdates.Checkin = testDataHelper.dateGenerator();
            bookingdates.Checkout = testDataHelper.dateGenerator().AddDays(5);
            return new BookingModel
            {
                Firstname = "Mj",
                Lastname = "Caparas",
                Totalprice = 42,
                Depositpaid = true,

                Bookingdates = bookingdates,
                Additionalneeds = "Drinks"

            };
        }
    }
}
