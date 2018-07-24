using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;

namespace myRetail_StephanieRatanas.Models
{



    [JsonObject]
    public class RootRedSkyResults
    {
        [JsonProperty("product")]
        public product Product { get; set; }


        public object Json { get; set; }

        public List<RootMongoDBResults> DBList { get; set; }


    }

    public class product
    {
        [BsonElement("item")]
        //[JsonProperty("item")]
        public item item { get; set; }
    }

    public class item
    {
        [JsonProperty("tcin")]
        public string product_Id { get; set; }

        [JsonProperty("product_description")]
        public product_decription product_description { get; set; }

    }

    public class product_decription
    {
        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("bullet_description")]
        public string[] bullet_description { get; set; }

    }
}
