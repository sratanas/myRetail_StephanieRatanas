using System;
using Newtonsoft.Json;

namespace myRetail_StephanieRatanas.Models
{
    [JsonObject]
    public class RootRedSkyResults
    {
        [JsonProperty("product")]
        public product Product { get; set; }


    }

    public class product
    {
        [JsonProperty("available_to_promise_network")]
        public available_to_promise_network available_To_Promise_Network { get; set; }
    }

    public class available_to_promise_network
    {
        [JsonProperty("product_id")]
        public string product_Id { get; set; }
    }

}
