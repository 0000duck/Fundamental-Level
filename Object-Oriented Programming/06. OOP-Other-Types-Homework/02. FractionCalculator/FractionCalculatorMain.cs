﻿using System;

namespace _02.FractionCalculator
{
    class FractionCalculatorMain
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);// 368 / 28 ==  (368/4) / (28/4)  ==  92 / 7
        }
    }
}
