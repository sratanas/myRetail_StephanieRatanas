using System;
using myRetail_StephanieRatanas.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace myRetail_StephanieRatanas.Services
{
    public  interface IRedSkyRepository
    {
        Task<RootMongoDBResults> GetProductById(string id);
        Task<List<RootMongoDBResults>> GetAllProductsFromDatabase();
    }
}
