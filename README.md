# GeolocationAPI

A simple .Net6 API to get exact location from users input.

## Valdation

- To return value, input string must be at least 3 char long
- Example of too short input string:

                  /api/Geolocation/ko?lang=cs&limit=5

## Making request for completing address

Usage:

                  /api/Geolocation/{addressLine}
      
- Returns array of unified model of address   
- Example of returned value: 
      
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
- Default number of returned addresses is 5. 
- You can change this, by adding limit value
- Example of adding limit for request output:

                  /api/Geolocation/komensk%C3%A9ho&limit=8
                  
-You can also set language of output
-Just simply add lang={your_language} -> CS,EN,DE,SK,AU,IT...
-Example of setting language of output:
            
                  /api/Geolocation/komensk%C3%A9ho?lang=cs
