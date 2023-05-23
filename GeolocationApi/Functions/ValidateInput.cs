using System;
namespace GeolocationApi.Functions
{
	public class ValidateInput
	{
        /// <summary>
        /// Function for validation of input (min lenght of string)
        /// </summary>
        /// <param name="input">Input of type string to validate</param>
        /// <param name="minLenght">min lenght of input for validation</param>
        /// <returns>Returns bool response if input string is valid or not</returns>
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

