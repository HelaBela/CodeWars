using System.Collections.Generic;
using System.Linq;

namespace codeWars
{
    public class RemoveFromList
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
          
            List<int> newIntegerList = integerList.ToList(); // two different objkects
            List<int> newValueslist = valuesList.ToList();

           foreach (var number in integerList)
           {
               if (newValueslist.Contains(number))
               {
                   newIntegerList.Remove(number);
               }
           }

           return newIntegerList.ToArray();
        }
        
    }
}