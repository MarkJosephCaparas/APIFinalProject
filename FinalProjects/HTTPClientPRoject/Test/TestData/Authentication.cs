using HttpClientProject.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientProject.Test.TestData
{
    //Authentication
    public class Authentication
    {
        public static USer userModel()
        {
            return new USer
            {
                Username = "admin",
                Password = "password123"
            };
        }
    }
}
