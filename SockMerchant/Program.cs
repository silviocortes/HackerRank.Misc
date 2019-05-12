using System;
using System.Collections.Generic;

namespace SockMerchantProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            int result = SockMerchant(n, ar);

            Console.WriteLine(result);
        }

        static int SockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> sockCounts = new Dictionary<int, int>();

            foreach(int i in ar) 
            {
                if (sockCounts.ContainsKey(i))
                    sockCounts[i] = sockCounts[i] + 1;
                else
                    sockCounts.Add(i, 1);
            }

            int pairOfSocksCount = 0;
            foreach (KeyValuePair<int,int> sockCount in sockCounts)
            {
                pairOfSocksCount = pairOfSocksCount + (sockCount.Value / 2);
            }

            return pairOfSocksCount;
        }
    }
}
