using System;

namespace codeWars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine(CountCharInString("world", 'x'));

            Console.WriteLine(XOXO("xxoO"));
            Console.WriteLine(XOXO("xoo"));
        }

        private static int SquareDigits(int n)
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

        private static int CountCharInString(string word, char checkChar)
        {
            var charArray = word.ToLower().ToCharArray();
            var timesTheCharaterAppears = 0;

            foreach (var character in charArray)
            {
                if (checkChar == character)
                {
                    timesTheCharaterAppears++;
                }
            }

            return timesTheCharaterAppears;
        }

        private static bool XOXO(string word)
        {
            return CountCharInString(word, 'x') == CountCharInString(word, 'o');
        }
    }
}