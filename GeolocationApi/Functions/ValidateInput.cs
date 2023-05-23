using System;
namespace GeolocationApi.Functions
{
	public class ValidateInput
	{
		// Function for validation of input (min lenght of string)

		public static bool IsValid(string input, int minLenght)
		{
			if(input.Length >= minLenght)
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

