namespace codeWars
{
    public class BalancedNumber
    {
        public static string BalancedNumberMethod(int number)
        {
            var givenNumberSplit = number.ToString().ToCharArray();
            int sumToLeft = 0;
            int sumToRight = 0;
        
            if (givenNumberSplit.Length % 2 != 0)
            {

                var middleIndex = givenNumberSplit.Length / 2;
            

                for (int i = 0; i <middleIndex; i++)
                {
                    sumToLeft += givenNumberSplit[i];
                }

                for (int j = middleIndex+1; j < givenNumberSplit.Length; j++)
                {
                    sumToRight += givenNumberSplit[j];
                }
            
            }
            else 
            {
                var middleIndex1 = givenNumberSplit.Length / 2; // = 2
                var middleIndex2 = givenNumberSplit.Length / 2 - 1; // = 1

                for (int i = 0; i < middleIndex2; i++)
                {
                    sumToLeft += givenNumberSplit[i];
                }

                for (int j=middleIndex1+1; j < givenNumberSplit.Length  ; j++ )
                {
                    sumToRight += givenNumberSplit[j];
                }
            
            }
            if (sumToLeft == sumToRight)
            {
                return "Balanced";
            }

            return "not balanced";
        }

    }
}
