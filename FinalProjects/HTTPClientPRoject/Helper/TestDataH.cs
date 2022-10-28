using HttpClientProject.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientProject.Helpers
{
    //TestDataH.cs
    public class TestDataH
    {
        public DateTime dateGenerator()
        {
            DateTime datenow = DateTime.Now.Date;

            return datenow;
        }
    }
}
