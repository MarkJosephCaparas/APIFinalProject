using SOAPReference;

namespace ProjectSOAP.Connected_Services.SOAPReference
{
    [TestClass]
    public class Test
    {
        CountryInfoServiceSoapTypeClient SOapService = null;

        private List<tCountryCodeAndName> CountryList(CountryInfoServiceSoapTypeClient service)
        {
            return service.ListOfCountryNamesByCode();
           
        }


        private tCountryCodeAndName CountryOfRandomList(List<tCountryCodeAndName> listOfCountry)
        {
            Random random = new Random();
            var randomlist = listOfCountry.Count - 1;
            int address = random.Next(0, randomlist);
            return listOfCountry[address];
        }

        [TestInitialize]
        public void initialize()
        {
            SOapService = new CountryInfoServiceSoapTypeClient(CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var randomCountry = CountryOfRandomList(CountryList(SOapService));
            
            var Details = SOapService.FullCountryInfo(randomCountry.sISOCode);

            Assert.AreEqual(randomCountry.sISOCode, Details.sISOCode);
            Assert.AreEqual(randomCountry.sName, Details.sName);
        }



        [TestMethod]
        public void TestMethod2()
        {

            List<tCountryCodeAndName> CountryList = new List<tCountryCodeAndName>();

            foreach (var country in CountryList.Take(5))
            {
                var Code = SOapService.CountryISOCode(country.sName);

                Assert.AreEqual(country.sISOCode, Code);
            }
        }
    }
}
