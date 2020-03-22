using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAutomation.Models.Configuration;
using HomeAutomation.Models.Entities;
using HomeAutomation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private ILookupService lookupService;

        public LookupController(ILookupService lookupService)
        {
            this.lookupService = lookupService;
        }

        [HttpGet("categories")]
        [ResponseCache(CacheProfileName = ResponseCacheProfile.ShortTimeCache)]
        public async Task<IActionResult> GetCategoriesLookup()
        {
            var lookup = await lookupService.GetEntityToLookupAsync<Category>();
            return Ok(lookup);
        }

        [HttpGet("deviceTypes")]
        [ResponseCache(CacheProfileName = ResponseCacheProfile.ShortTimeCache)]
        public async Task<IActionResult> GetDeviceTypesLookup()
        {
            var lookup = await lookupService.GetEntityToLookupAsync<DeviceType>();
            return Ok(lookup);
        }

        [HttpGet("producers")]
        [ResponseCache(CacheProfileName = ResponseCacheProfile.ShortTimeCache)]
        public async Task<IActionResult> GetProducersLookup()
        {
            var lookup = await lookupService.GetEntityToLookupAsync<Producer>();
            return Ok(lookup);
        }
    }
}