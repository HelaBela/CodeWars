using System;
using System.Collections.Generic;
using System.Linq;

namespace codeWars
{
    internal class Program
    {
        private static void Main(string[] args)
        
        {
          
            
           var keepRunning = true;
            while (keepRunning)
            {
                Execute();
                Console.WriteLine("do you want to keep going? Say yes or no");
                
                if (Console.ReadLine() == "no")
                {
                    keepRunning = false;
                }
            }
        }

        private static void Execute()
        {
            Console.WriteLine($"please choose which Kata you want to run. " + Environment.NewLine +
                              "type '1' for Square Digits " + Environment.NewLine +
                              "type '2' for Counting Characters" + Environment.NewLine +
                              "type '3' for Dividors" + Environment.NewLine +
                              "type '4' for a Square Kata" + Environment.NewLine +
                              "type '5' for  Tidy Number" + Environment.NewLine +
                              "type '6' for Array Leaders" + Environment.NewLine +
                              "type '7' for Duplicates in array" + Environment.NewLine +
                              "type '8' for a Balanced Number");

            var userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("choose a number to square its digits and present in one line");
                int squareNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SquareDigits.SquareDigitsMethod(squareNumber));

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Check to see if a string has the same amount of 'x's and 'o's. Choose a string to test");
                var wordFromUser = Console.ReadLine();
                Console.WriteLine(CountChars.CountCharInString("world", 'x'));
                Console.WriteLine(CountChars.XOXO(wordFromUser));
            }
            else if (userInput == "3")
            {
                foreach (var number in DividorsClass.Divisors(1300000000))
                {
                    Console.WriteLine(number);
                }
            }
            else if (userInput == "4")
            {
                Console.WriteLine(Square.GenerateSquare(2));
            }
            else if (userInput == "5")
            {
                Console.WriteLine(TidyNumberClass.TidyNumber2(5));
                Console.WriteLine(TidyNumberClass.TidyNumber(5));
            }
            else if (userInput == "6")
            {
                foreach (var number in ArrayLeadersClass.ArrayLeaders(new int[] {1, 2, 5, 1, 3}))
                {
                    Console.WriteLine(number);
                }
            }
            else if (userInput == "7")
            {
                Console.WriteLine(DuplicatesCount.MostFrequentItem(new int[] {2, 1, 1, 1, 1, 1, 1, 1, 1, 3, 4}));
                Console.WriteLine(DuplicatesCount.MostFrequentItemCount(new int[] {2, 1, 1, 1, 1, 1, 1, 1, 1, 3, 4}));

                Console.WriteLine(DuplicatesCount.GetAgeForPerson("Tohny"));
            }
            else if (userInput == "8")
            {
                Console.WriteLine(BalancedNumber.BalancedNumberMethod(1131));
            }
            else if (userInput == "9")
            {
                var integerList = new int[] {8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2, 3};
                var valuesList = new int[] {2, 4, 3};

                foreach (var number in RemoveFromList.Remove(integerList, valuesList))
                {
                    Console.WriteLine(number);
                }
            } 
            else if (userInput == "10")
            {
                Console.WriteLine(Mumbling.Accum("abcd"));
            }
            else if (userInput == "11")
            { 
                Console.WriteLine(CreateAPhoneNumber.CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0}));
            }
        }

    }
}