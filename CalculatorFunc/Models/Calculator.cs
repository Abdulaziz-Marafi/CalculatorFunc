﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunc.Models
{
    internal class Calculator
    {
        public static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int sum(int num1, int num2, int num3)
        {
           return num1 + num2 + num3;
        }

        public static double addBonus(int hours, double hourRate)
        {
            return hours * hourRate;
        }

    }
}
