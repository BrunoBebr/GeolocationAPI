﻿using System;
using System.Text.Json.Serialization;

namespace GeolocationApi.Models
{
    public class UniversalAddressResponseModel
    {
        [JsonPropertyName("results")]
        public IList<UniversalAddressModel>? GetItems { get; set; } = new List<UniversalAddressModel>();
    }
	public class UniversalAddressModel
	{
        /// <summary>
        /// Address (ex. "Dlouhá 11/2")
        /// </summary>
        [JsonPropertyName("address")]
        public string? address { get; set; }

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

