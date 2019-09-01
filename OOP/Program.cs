using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Block b = new Block(new int[] {2,3,4});
            Console.WriteLine(b.GetWidth());
        }
    }
}