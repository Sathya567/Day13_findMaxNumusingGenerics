﻿using System;

namespace Day13_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum Number");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(22, 33, 44);
            //Console.WriteLine(output);

            //double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(12.7, 20.47, 80.56);
            //Console.WriteLine(doubleoutput);

            //string strigoutput = MaximumNumberCheck.MaximumStringNumber("apple", "peach", "Banana");
            //Console.WriteLine(strigoutput);

            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "peach", "Banana", "Grapes" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

            Console.ReadKey();



        }
    }
}
