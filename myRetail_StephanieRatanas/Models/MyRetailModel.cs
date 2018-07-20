using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;

namespace myRetail_StephanieRatanas.Models
{
    [JsonObject]
    public class MyRetailModel
    {
        
        public product JsonFromApi { get; set; }
    }

    //[JsonObject]
    //public class product
    //{
    //    [JsonProperty("available_to_promise_network")]
    //    public available_to_promise_network available_To_Promise_Network { get; set; }
    //}

    //public class available_to_promise_network
    //{
    //    [JsonProperty("product_id")]
    //    public product_id product_Id { get; set; }
    //}

    //public class product_id
    //{
    //}
}

