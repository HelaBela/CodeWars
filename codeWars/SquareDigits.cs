using System;

namespace codeWars
{
    public class SquareDigits
    {
        public static int SquareDigitsMethod(int n)
        {
            var myNumber = n.ToString();
            var charArray = myNumber.ToCharArray();
            var itemInResult = "";
            var result = "";

            foreach (var numberChar in charArray)
            {
                var number = int.Parse(numberChar.ToString()); //converted a char item into int
                itemInResult = (number * number).ToString();

                result += itemInResult;
            }

            return Convert.ToInt32(result);
        }
    }
}