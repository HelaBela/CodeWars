using System;
using System.Collections.Generic;
using System.Linq;

namespace codeWars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Console.WriteLine("please choose which Kata you want to run. " +
                              "type '1' for Square Digits " +
                              "type'2' for Counting Characters" +
                              "type '3' for Dividors" +
                              "type '4' for a Square Kata"+
                              "type '5' for  Tidy Number"+
                              "type '6' for Array Leaders"+
                              "type '7' for Duplicates in array"+
                              "type '8' for a Balanced Number");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine(SquareDigits.SquareDigitsMethod(3));
                
            }else if (Console.ReadLine() =="2") {
                Console.WriteLine(CountChars.CountCharInString("world", 'x'));
                Console.WriteLine(CountChars.XOXO("xxoO"));
                Console.WriteLine(CountChars.XOXO("xoo"));
            }else if (Console.ReadLine() =="3") {
                 foreach(var number in DividorsClass.Divisors(1300000000)) { Console.WriteLine(number); }
            }else if (Console.ReadLine() =="4") {
                Console.WriteLine(Square.GenerateSquare(2));
            }else if (Console.ReadLine() =="5") {
                Console.WriteLine(TidyNumberClass.TidyNumber2(5));
                Console.WriteLine(TidyNumberClass.TidyNumber(5));
            }else if (Console.ReadLine() =="6") {
                foreach (var number in ArrayLeadersClass.ArrayLeaders(new int[]{1,2, 5, 1,3}))
                {
                    Console.WriteLine(number);
                }
            }else if (Console.ReadLine() =="7") {
                Console.WriteLine(DuplicatesCount.MostFrequentItem(new int[]{2,1,1,1,1,1,1,1,1,3,4}));
                Console.WriteLine(DuplicatesCount.MostFrequentItemCount(new int[]{2,1,1,1,1,1,1,1,1,3,4}));
                
                //Console.WriteLine(DuplicatesCount.GetAgeForPerson("Tohny"));
            }else if (Console.ReadLine() == "8")
            {
                //Console.WriteLine(BalancedNumber(1131));
            }

        */
            Console.WriteLine(DuplicatesCount.MostFrequentItem(new int[] {2, 1, 1, 1, 1, 1, 1, 1, 1, 3, 4}));

            // Console.WriteLine(BalancedNumber(1131));


        }

        

        private static string BalancedNumber(int number)
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
        else if(givenNumberSplit.Length % 2 == 0 )
        {
            var middleIndex1 = givenNumberSplit.Length / 2;
            var middleIndex2 = givenNumberSplit.Length / 2 - 1;

            for (int i = 0; i < middleIndex2; i++)
            {
                sumToLeft += givenNumberSplit[i];
            }

            for (int j=middleIndex1 ; j < givenNumberSplit.Length  ; j++ )
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