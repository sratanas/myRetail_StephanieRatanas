using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace myRetail_StephanieRatanas.Services
{
    public interface IRedSkyService
    {
        Task<object> ReturnAllApiData();

    }
}
