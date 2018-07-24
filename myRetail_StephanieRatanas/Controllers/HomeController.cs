using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myRetail_StephanieRatanas.Models;
using myRetail_StephanieRatanas.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace myRetail_StephanieRatanas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRedSkyService _redSkyService;
        private readonly IRedSkyRepository _redSkyRepository;

        public HomeController(IRedSkyService redSkyService, IRedSkyRepository redSkyRepository)
        {
            _redSkyService = redSkyService;
            _redSkyRepository = redSkyRepository;
        }
        [Route("/products/{id}")]
        public async Task<IActionResult> Index(string id)
        {
            var model = new RootRedSkyResults();
            model.ApiResults = await _redSkyService.ReturnAllApiData();
            model.MongoResultById = await _redSkyRepository.GetProductById(id);



            //model.Product.item.product_description.Price = 
            //model.MongoSerialized = JObject.Parse(JsonConvert.SerializeObject(model.MongoResultById));
            //model.reserializedJson = JObject.Parse(JsonConvert.SerializeObject(model.ApiResults));

            //var mongomongo = JsonConvert.SerializeObject(model.MongoResultById);
            //var apiapi = JsonConvert.SerializeObject(model.ApiResults);

            JObject Mongo = JObject.Parse(JsonConvert.SerializeObject(model.MongoResultById.Product));
            JObject Api = JObject.Parse(JsonConvert.SerializeObject(model.ApiResults.Product));

            Mongo.Merge(Api, new JsonMergeSettings
            {
                // union array values together to avoid duplicates
                MergeArrayHandling = MergeArrayHandling.Union
            });

            model.MergedJson = Mongo;

            return View(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
