﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculator
    {
        public static int Sum(params int [] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
