using System;
using System.Text.Json.Serialization;
namespace GeolocationApi.Models
{
    /// <summary>
    /// Model for GeoApify refponse
    /// </summary>
	public class GeoApifyResponseModel
	{
        [JsonPropertyName("results")]
        public IList<GeoApifyModel> GetItems { get; set; } = new List<GeoApifyModel>();
	}

    /// <summary>
    /// Model for each address form GeoApify response
    /// </summary>
	public class GeoApifyModel
	{
        /// <summary>
        /// Street (ex. "Dlouhá")
        /// </summary>
        [JsonPropertyName("street")]
        public string? street { get; set; }

        /// <summary>
        /// House number (ex. "600/22")
        /// </summary>
        [JsonPropertyName("housenumber")]
        public string? housenumber { get; set; }

        /// <summary>
        /// City (ex. "Praha")
        /// </summary>
        [JsonPropertyName("city")]
        public string? city { get; set; }

        /// <summary>
        /// ZIP code (ex. "11000")
        /// </summary>
        [JsonPropertyName("postcode")]
        public string? zipCode { get; set; }

        /// <summary>
        /// Country (ex. "Česko")
        /// </summary>
        [JsonPropertyName("country")]
        public string? country { get; set; }

        /// <summary>
        /// Latitude (ex. "50.140404")
        /// </summary>
        [JsonPropertyName("lat")]
        public double? lat { get; set; }

        /// <summary>
        /// Lontitude (ex. "15.125625")
        /// </summary>
        [JsonPropertyName("lon")]
        public double? lon { get; set; }
    }
}

