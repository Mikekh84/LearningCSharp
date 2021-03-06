﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];

            //assigns an array
            numbers[0] = 4;
            numbers[1] = 5;
            numbers[2] = 82723;
            numbers[3] = 234;
            numbers[4] = 23;

            //Shows length of array
            Console.WriteLine("Length of Numbers Array: " + numbers.Length);
            Console.WriteLine("Numbers in Array");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Reverse Array And Write a log
            System.Array.Reverse(numbers);
            Console.WriteLine("------");
            Console.WriteLine("Numbers in reverse.");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
