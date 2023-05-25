using System;
namespace GeolocationApi.Services
{
	public class InputValidationService
	{
		public static bool ValidateString(string testedValue, int minLenght)
		{
			if( testedValue.Length >= minLenght || testedValue != null)
			{
				return true;
			}
			else
			{
				return false;
			}
			
		}

        public static bool ValidateInt(int testedValue, int minValue)
        {
            if (testedValue > minValue)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

	
}

