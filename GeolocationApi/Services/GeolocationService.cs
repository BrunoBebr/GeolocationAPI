using System;
using GeolocationApi.Functions;
using System.Text.Json;
using GeolocationApi.Models;
using Microsoft.Extensions.Options;

namespace GeolocationApi.Services
{
    
	public class GeolocationService : IGeolocationService
	{
        private readonly IHttpClientFactory? httpClientFactory;
        private readonly IOptions<ConfigModel> config;

        public  GeolocationService(IOptions<ConfigModel> config, IHttpClientFactory httpClientFactory)
        {
            this.config = config;

            this.httpClientFactory = httpClientFactory;

        }

        public async Task<UniversalAddressResponseModel> GeoApifyResponseHandler(
			string addressLine,
			string lang,
			int limit,
            string countryLimit,
            string preferedCountry
			)
		{
            string otherParams = "";

            if(countryLimit != null)
            {
                otherParams = otherParams + "&filter=countrycode:" + countryLimit;
            }
            if(preferedCountry != null)
            {
                otherParams = otherParams + "&bias=countrycode:" + preferedCountry;
            }
            
            String APIKey = config.Value.APIKey!;

            string url = "https://api.geoapify.com/v1/geocode/";

            using HttpClient client = httpClientFactory.CreateClient();

            client.BaseAddress = new Uri(url);

            GeoApifyResponseModel? geoApifyModel = await client.GetFromJsonAsync<GeoApifyResponseModel>(
                       $"autocomplete?text={addressLine}&lang={lang}&limit={limit}&type=amenity{otherParams}&format=json&apiKey={APIKey}",
                        new JsonSerializerOptions(JsonSerializerDefaults.Web));

            var output = ModelConverter.GeoApifyModelToUniversalModel(geoApifyModel!);


            return output;
		}
	}
}

