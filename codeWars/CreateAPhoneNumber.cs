using System.Linq;

namespace codeWars
{
    
    //Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"

    public class CreateAPhoneNumber
    {
        public static string CreatePhoneNumber(int[] n)
        {
            return $"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}";

        }
        
    }
}