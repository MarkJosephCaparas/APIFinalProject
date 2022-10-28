﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPClientPRoject.DataModels
{
    //Booking
    public partial class Booking
    {
        [JsonProperty("bookingid")]
        public int Bookingid { get; set; }

        [JsonProperty("booking")]
        public BookingModel? BookingModel { get; set; }
    }

    public partial class BookingModel
    {
        [JsonProperty("firstname")]
        public string? Firstname { get; set; }

        [JsonProperty("lastname")]
        public string? Lastname { get; set; }

        [JsonProperty("totalprice")]
        public long Totalprice { get; set; }

        [JsonProperty("depositpaid")]
        public bool Depositpaid { get; set; }

        [JsonProperty("bookingdates")]
        public Bookingdates? Bookingdates { get; set; }

        [JsonProperty("additionalneeds")]
        public string? Additionalneeds { get; set; }
    }

    public partial class Bookingdates
    {
        [JsonProperty("checkin")]
        public DateTimeOffset Checkin { get; set; }

        [JsonProperty("checkout")]
        public DateTimeOffset Checkout { get; set; }
    }
}
