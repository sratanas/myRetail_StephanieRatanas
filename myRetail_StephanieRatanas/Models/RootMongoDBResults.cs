using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace myRetail_StephanieRatanas.Models
{
    
    public class RootMongoDBResults
    {
        [BsonElement("product")]
        public MongoProduct Product { get; set; }


        [BsonId]
        public ObjectId _id { get; set; }


    }

    public class MongoProduct
    {
        [BsonElement("item")]
        public MongoItem item { get; set; }


        //[BsonId]
        //public ObjectId _id { get; set; }

    }

    public class MongoItem
    {
        [BsonElement("product_description")]
        public MongoProduct_decription product_description { get; set; }

        [BsonElement("tcin")]
        public string product_Id { get; set; }

    }

    public class MongoProduct_decription
    {
        [BsonElement("title")]
        public string title { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }
    }

}
