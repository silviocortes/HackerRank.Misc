using System;

namespace IntroToConditionalStatements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (!(N % 2 == 0))
                Console.WriteLine("Weird");
            else
            {
                if (N >= 6 || N <= 20)
                {
                    Console.WriteLine("Weird");
                }   
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}
