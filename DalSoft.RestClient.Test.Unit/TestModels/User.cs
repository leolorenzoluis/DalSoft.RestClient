﻿using Newtonsoft.Json;

namespace DalSoft.RestClient.Test.Unit.TestModels
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        public string website { get; set; }
    }
}