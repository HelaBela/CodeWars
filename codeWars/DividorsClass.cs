using System;
using System.Collections.Generic;

namespace codeWars
{
    public class DividorsClass
    {
        public static int[] Divisors(int n)
        {
            var result = 0;
            var listOfResults = new List<int>();

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                result = n % i;
                if (result == 0)
                {
                    listOfResults.Add(i);
                    if (i != Math.Sqrt(n))
                    {
                        listOfResults.Add(n /i);
                    }
                }
            }

            if (listOfResults.Count == 0)
            {
                return null;
            }
            listOfResults.Sort();
            return listOfResults.ToArray();

        }

    }
}