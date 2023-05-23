using System;
using GeolocationApi.Models;

namespace GeolocationApi.Services
{
	public interface IGeolocationService
	{
        Task<UniversalAddressResponseModel> GeoApifyResponseHandler(
           string addressLine,
           string lang,
           int limit
           );

    }
}

