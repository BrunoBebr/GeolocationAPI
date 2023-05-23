using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GeolocationApi.Functions;
using GeolocationApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeolocationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GeolocationController : Controller
    {
        private readonly IHttpClientFactory? httpClientFactory;
        private readonly IOptions<ConfigModel> config;

        public GeolocationController(IOptions<ConfigModel> config, IHttpClientFactory httpClientFactory)
        {
            this.config = config;

            this.httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Returns most similar locations
        /// </summary>
        /// <param name="addressLine"> String on input</param>
        /// <param name="limit"> Limit how many addresses should be returned</param>
        /// <param name="lang"> Language of output</param>
        /// <returns> JSON array of top similar locations</returns>
        /// 
        [HttpPost]
        [Route("{addressLine}")]



        public async Task<IActionResult> GetGeolocationLimit([FromRoute] String addressLine, [FromQuery] string lang = "cs", int limit = 5)
        {
            if (ValidateInput.IsValid(addressLine, 3))
            {
                string APIKey = config.Value.APIKey!;

               

                string url = "https://api.geoapify.com/v1/geocode/";

                using HttpClient client = httpClientFactory.CreateClient();

                client.BaseAddress = new Uri(url);


                GeoApifyResponseModel? geoApifyModel = await client.GetFromJsonAsync<GeoApifyResponseModel>(
                       $"autocomplete?text={addressLine}&lang={lang}&limit={limit}&type=amenity&format=json&apiKey={APIKey}",
                        new JsonSerializerOptions(JsonSerializerDefaults.Web));

                var output = ModelConverter.GeoApifyModelToUniversalModel(geoApifyModel!);

                return Ok(output);
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}

