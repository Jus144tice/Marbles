using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
    public static class StringHelper
    {
        public static bool IsPalindrome(String input)
        {
            String lowerCaseTest = input.ToLower();
            char[] chars = lowerCaseTest.ToCharArray();
            StringBuilder sb = new StringBuilder();

            foreach (char c in chars)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }

            string cleanedAndLoweredString = sb.ToString();
            char[] cleanedChars = cleanedAndLoweredString.ToCharArray();
            Array.Reverse(cleanedChars);
            string reversed = new string(cleanedChars);

            if (reversed == cleanedAndLoweredString)
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
