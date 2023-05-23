# GeolocationAPI

A simple .Net6 API to get exact location from users input.

## Making request for completing address

Usage - "/api/Geolocation/{addressLine}"
      
      - Returns array of unified model of address
      
      - Example of returned value: 
      ```json
              {
                "results": [
                  {
                    "address": "Komenského 332",
                    "city": "Golčův Jeníkov",
                    "postcode": "58282",
                    "country": "Česko",
                    "lat": 49.815569,
                    "lon": 15.47309
                  },
                  {
                    "address": "Komenského 241",
                    "city": "Golčův Jeníkov",
                    "postcode": "58282",
                    "country": "Česko",
                    "lat": 49.815694,
                    "lon": 15.472944
                  },
                  {
                    "address": "Komenského 407",
                    "city": "Golčův Jeníkov",
                    "postcode": "58282",
                    "country": "Česko",
                    "lat": 49.816552,
                    "lon": 15.473288
                  },
                  {
                    "address": "Komenského 267",
                    "city": "Golčův Jeníkov",
                    "postcode": "58282",
                    "country": "Česko",
                    "lat": 49.815955,
                    "lon": 15.472519
                  },
                  {
                    "address": "Komenského 303",
                    "city": "Golčův Jeníkov",
                    "postcode": "58282",
                    "country": "Česko",
                    "lat": 49.816296,
                    "lon": 15.472591
                  }
                ]
              }
           ```
