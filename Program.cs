﻿using System;

namespace conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            int result1 = (int)((decimal)value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = value2/(decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = value3/(float)value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}
