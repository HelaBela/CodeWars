using System.Collections.Generic;
using System.Linq;

namespace codeWars
{
    public class DuplicatesCount
    {
        public static int MostFrequentItem( int[] input)
        {
            var numbers = new Dictionary<int, int>();
            foreach (var number in input)
            {
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }
            
            var largestItem = new KeyValuePair<int,int>(0,0);
            foreach (var item in numbers)
            {
                if (item.Value > largestItem.Value)
                {
                    largestItem = item;
                }
            }

            return largestItem.Key;
        }


        public static int MostFrequentItemCount(int[] collection)
        {
            var givenCollection = collection.ToList();
            var largestCount =0 ;

            foreach(var letter in givenCollection)
            {
                var count= givenCollection.Count(i => i == letter);

                if (count > largestCount)
                {
                    largestCount = count;
                }

            }

            return largestCount;
        }
        
        

        public static int GetAgeForPerson (string name)
        {
            var people = new Dictionary<string, int>();
            
            people.Add("Helena", 34);
            people.Add("Tony", 25);
            people.Add("Alex", 30);
            people.Add("John", 20);
            people.Add("Adam", 14);

            if (people.TryGetValue("Helena", out var guess))
            {
                return guess;
            }

            return 0;
            

        }

    }
}