using System;

namespace codeWars
{
    public class TidyNumberClass
    {
        
        public static bool TidyNumber(int n)
        {
            char[] givenNumbers = n.ToString().ToCharArray();

            for (int i = 0; i < givenNumbers.Length; i++)
            {
                for (int j = i; j < givenNumbers.Length; j++)
                {
                    if (Convert.ToInt16(givenNumbers[i]) > Convert.ToInt16(givenNumbers[j]))
                    {
                        return false;
                    }
                }
            }

            return true;
            
        }
        
        
        public static bool TidyNumber2(int n)
        {
            var givenNumbers = n.ToString().ToCharArray();

            for (int i = 1; i < givenNumbers.Length; i++)
            {
                if (Convert.ToInt16(givenNumbers[i]) < Convert.ToInt16(givenNumbers[i - 1]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}