using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    public static class ErrorHandling
    {
        public static void CustomError(int input, string CustomErrorMessage, int minLength, int maxLength)
        {
            if (input < minLength && input > maxLength)
            {
                throw new ArgumentOutOfRangeException(CustomErrorMessage);
            }
        }

        public static void ValidationOfInput(string input, string CustomErrorMessage, int minLength, int maxLength)
        {
            if (input.Length < minLength && input.Length > maxLength)
            {
                throw new ArgumentOutOfRangeException(CustomErrorMessage);
            }
        }

        public static void CustomError(Track input, string CustomErrorMessage)
        {
            if (input != Track.Dev && input != Track.Frontend && input!= Track.None)
            {
                throw new ArgumentOutOfRangeException(CustomErrorMessage);
            }
        }

        public static void CustomError(float input, string CustomErrorMessage, float minLength, float maxLength)
        {
            if (input < minLength && input > maxLength)
            {
                throw new ArgumentOutOfRangeException(CustomErrorMessage);
            }
        }
    }
}
