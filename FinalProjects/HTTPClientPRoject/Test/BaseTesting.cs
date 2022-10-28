using HttpClientProject.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HttpClientProject.Helpers;

namespace HttpClientProject.Test
{
    //BaseTesting
    public class BaseTest
    {
        public HttpClient? httpClient { get; set; }

        public BookingH? bookingDetails { get; set; }

        [TestInitialize]
        public void Initilize()
        {
            httpClient = new HttpClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }

    }
}
