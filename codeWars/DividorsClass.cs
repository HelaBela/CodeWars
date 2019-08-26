using System.Collections.Generic;

namespace codeWars
{
    public class DividorsClass
    {
        public static int[] Divisors(int n)
        {
            var result = 0;
            var listOfResults = new List<int>();

            for (int i = 2; i < n; i++)
            {
                result = n % i;
                if (result == 0)
                {
                    listOfResults.Add(i);
                }
            }

            return listOfResults.ToArray();
        }

    }
}