using System;
using myRetail_StephanieRatanas.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace myRetail_StephanieRatanas.Services
{
    public  interface IRedSkyRepository
    {
        //Task<IEnumerable<RootRedSkyResults>> GetAllProducts();
        Task<RootMongoDBResutls> GetProductById(string id);
    }
}
