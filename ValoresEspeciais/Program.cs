﻿using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_int = int.MaxValue;

            int min_int = int.MinValue;

            float max_flo = float.MaxValue;

            float min_flo = float.MinValue;

            double max_dou = double.MaxValue;

            double min_dou = double.MinValue;

            decimal max_dec = decimal.MaxValue;

            decimal min_dec = decimal.MinValue;

            double infinity_plus = double.PositiveInfinity;

            double infinity_minus = double.NegativeInfinity;

            double nothing = double.NaN;

            float floatinf_plus = float.PositiveInfinity;

            float floatinf_minus = float.NegativeInfinity;

            float nothing_f = float.NaN;

            Console.WriteLine("Max Values");

            Console.WriteLine("Int: {0}\nFloat: {1}",max_int,max_flo);

            Console.WriteLine("Double: {0}\nDecimal: {1}",max_dou,max_dec);

            Console.WriteLine("Min Values");

            Console.WriteLine("Int: {0}\nFloat: {1}",min_int,min_flo);

            Console.WriteLine("Double: {0}\nDecimal: {1}",min_dou,min_dec);

            Console.WriteLine("Special Values");

            Console.WriteLine("{0}\n{1}",infinity_plus,infinity_minus);

            Console.WriteLine("{0}\n{1}",floatinf_plus,floatinf_minus);

            Console.WriteLine("{0}\n{1}",nothing,nothing_f);

        }
    }
}
