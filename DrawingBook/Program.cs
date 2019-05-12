using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DrawingBook
{
    //https://www.hackerrank.com/challenges/drawing-book/problem
    class MainClass
    {
        /*
        * Complete the pageCount function below.
        */
        static int pageCount(int n, int p)
        {
            int d1 = (int) Math.Floor(p / 2.0);

            int d2 = (int) Math.Floor(n / 2.0) - d1;

            if (d1 > d2)
                return d2;
            else
                return d1;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            do
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int p = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(pageCount(n, p));
            } while (!Console.ReadLine().Equals("end"));

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
