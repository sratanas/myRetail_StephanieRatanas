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


        [HttpGet]
        [Route("/products/{id}")]
        public async Task<IActionResult> Index(string id)
        {
            var model = new RootRedSkyResults();

            var ApiResults = await _redSkyService.ReturnAllApiData();
            var MongoResultById = await _redSkyRepository.GetProductById(id);


            JObject Mongo = JObject.Parse(JsonConvert.SerializeObject(MongoResultById.Product));
            JObject Api = JObject.Parse(JsonConvert.SerializeObject(ApiResults.Product));

            if(id == ApiResults.Product.item.product_Id)
            {
                Mongo.Merge(Api, new JsonMergeSettings
                {
                    // union array values together to avoid duplicates
                    MergeArrayHandling = MergeArrayHandling.Union
                });

                model.MergedJson = Mongo;

                return View(model);
            }
            else
            {
                model.MergedJson = Mongo;
                return View(model);
            }


        }

        [HttpPut]
        public IActionResult ChangeItemPrice()
        {

            return View("Index");
        }




    }
}
