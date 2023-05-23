using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using GeolocationApi.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GeolocationApi.Functions
{
	public class ModelConverter
	{

		public static UniversalAddressResponseModel GeoApifyModelToUniversalModel(GeoApifyResponseModel results)
		{
			UniversalAddressResponseModel universalResponse = new UniversalAddressResponseModel();

			IList<UniversalAddressModel> GetItems = new List<UniversalAddressModel> {};

			if(universalResponse.GetItems == null)
			{
				universalResponse.GetItems = new List<UniversalAddressModel> { };
			}

			foreach (var result in results.GetItems)
			{
				universalResponse.GetItems.Add(new UniversalAddressModel {
					address = result.street + " " + result.housenumber,
					city = result.city,
					zipCode = result.zipCode,
					country = result.country,
					lat = result.lat,
					lon = result.lon
				});   
            }

            return universalResponse;
		}
		
	}
}

