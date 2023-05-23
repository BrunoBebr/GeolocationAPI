using System;
namespace GeolocationApi.Models
{
	public class GeolocationSearch
	{
		/// <summary>
		/// Address for geolocation
		/// </summary>
		public string Address { get; set; }	
	}

	public class Geolocation
	{
		public string Country { get; set; }

		public string CountryCode { get; set; }
	}
}

