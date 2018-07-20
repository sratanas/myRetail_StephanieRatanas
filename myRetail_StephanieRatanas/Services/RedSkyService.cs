using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myRetail_StephanieRatanas.Models;
using Newtonsoft.Json;

namespace myRetail_StephanieRatanas.Services
{
    public class RedSkyService : IRedSkyService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<RootRedSkyResults> ReturnAllApiData()
        {
            
            var url = new Uri($"http://redsky.target.com/v2/pdp/tcin/13860428?excludes=taxonomy,price,promotion,bulk_ship,rating_and_review_reviews,rating_and_review_statistics,question_answer_statistics");

            var response = await client.GetAsync(url);

            object result;
            //var content = response.Content;
            using(var content = response.Content)
            {
                result = await content.ReadAsAsync<object>();
            };

            //product details = JsonConvert.DeserializeObject<product>(result);
            RootRedSkyResults obj = JsonConvert.DeserializeObject<RootRedSkyResults>(result.ToString());

            return obj;

        }

    }
}
