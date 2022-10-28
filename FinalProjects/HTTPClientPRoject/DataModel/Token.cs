using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientProject.DataModels
{
    //Token
    public  class Tooken
    {
        [JsonProperty("token")]
        public string? Token { get; set; }
    }
}
