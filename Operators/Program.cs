﻿using System;

namespace Operators
{
    class MainClass
    {
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            Console.WriteLine(Math.Round(meal_cost + (meal_cost * (tip_percent / 100.0)) + (meal_cost * (tax_percent / 100.0))));
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
