using ServiceReference1;
using System.Collections.Generic;
using System.Reflection;
using System;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Soap.Test
{
    //Soap
    [TestClass]
    public class SoapTesting
    {
        CountryInfoServiceSoapTypeClient Service = null;
        
        private List<tCountryCodeAndName> CountryList(CountryInfoServiceSoapTypeClient service)
        {
            var listOfCountry = service.ListOfCountryNamesByCode();
            return listOfCountry;
        }
       
        private tCountryCodeAndName RandomListofCountryByDetails(List<tCountryCodeAndName> listOfCountry)
        {
            Random random = new Random();
            int index = random.Next(0, listOfCountry.Count - 1);
            return listOfCountry[index];
        }

        [TestInitialize]
        public void TestMethod1()
        {
            Service = new CountryInfoServiceSoapTypeClient(CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
        }

        [TestMethod]
        public void VerifyFullCountry()
        {
            var listOfCountryData = CountryList(Service);
            var randomCountry = RandomListofCountryByDetails(listOfCountryData);
            var fullCountryDetails = Service.FullCountryInfo(randomCountry.sISOCode);
            Assert.AreEqual(randomCountry.sISOCode, fullCountryDetails.sISOCode);
            Assert.AreEqual(randomCountry.sName, fullCountryDetails.sName);
        }
        [TestMethod]
        public void VerifyCodeMatches()
        {
            List<tCountryCodeAndName> listOfCountry = new List<tCountryCodeAndName>();
            var FiveCountries = listOfCountry.Take(5);
            foreach (var country in FiveCountries)
            {
                var countryISOCode = Service.CountryISOCode(country.sName);
                Assert.AreEqual(country.sISOCode, countryISOCode);
            }
        }
    }
}