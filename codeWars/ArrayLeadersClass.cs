using System.Collections.Generic;

namespace codeWars
{
    public class ArrayLeadersClass
    {
        public static int[] ArrayLeaders(int[] numbers)
        {
            var resultList = new List<int>();


            for (int a = 0; a < numbers.Length; a++)
            {
                int sum = 0;

                for (int i = a + 1; i < numbers.Length; i++)
                {
                    //this loop is only to sum up numbers to the right of the number we compare it with
                    sum += numbers[i];
                }

                if (numbers[a] > sum)
                {
                    resultList.Add(numbers[a]);
                }
            }

            return resultList.ToArray();
        }
    }
}