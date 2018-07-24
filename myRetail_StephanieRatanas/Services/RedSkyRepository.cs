using System;
using Microsoft.Extensions.Options;
using myRetail_StephanieRatanas.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Driver;
namespace myRetail_StephanieRatanas.Services
{
    public class RedSkyRepository : IRedSkyRepository
    {

        private readonly RedSkyContext _context = null;

        public RedSkyRepository(IOptions<Settings> settings)
        {
            _context = new RedSkyContext(settings);
        }


        public async Task<RootMongoDBResults> GetProductById(string id)
        {
            try
            {
                var result = await _context.RootRedSkyResults.Find(item => item.Product.item.product_Id == id)
                                           .FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
