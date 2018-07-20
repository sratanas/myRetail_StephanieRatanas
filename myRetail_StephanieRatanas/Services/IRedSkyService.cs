using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using myRetail_StephanieRatanas.Models;

namespace myRetail_StephanieRatanas.Services
{
    public interface IRedSkyService
    {
        Task<RootRedSkyResults> ReturnAllApiData();

    }
}
