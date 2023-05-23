using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GeolocationApi.Functions;
using GeolocationApi.Models;
using GeolocationApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeolocationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GeolocationController : Controller
    {
        private readonly IGeolocationService geolocationService;

        public GeolocationController(IGeolocationService geolocationService)
        {
            this.geolocationService = geolocationService;
        }

        /// <summary>
        /// Returns most similar locations
        /// </summary>
        /// <param name="addressLine"> String on input</param>
        /// <param name="limit"> Limit how many addresses should be returned</param>
        /// <param name="lang"> Language of output</param>
        /// <returns> JSON array of top similar locations</returns>

        
        [HttpGet]
        public async Task<IActionResult> GetGeolocationLimit(
            [FromQuery] String addressLine,
            [FromQuery] string lang = "cs",
            int limit = 5
            )
        {
            if (ValidateInput.IsValid(addressLine, 3))
            {
               UniversalAddressResponseModel output = await geolocationService.GeoApifyResponseHandler(addressLine, lang, limit);

               return Ok(output);
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}

