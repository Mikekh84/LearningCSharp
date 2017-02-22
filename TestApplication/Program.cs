using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
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

            //Reverse Array Test
            System.Array.Reverse(numbers);
            Console.WriteLine("------");
            Console.WriteLine("Numbers in reverse.");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Days today = Days.Tuesday;
            Console.WriteLine("Enum postion");
            Console.WriteLine((int) today);
            if(today == Days.Monday)
            {
                Console.WriteLine("It's Monday");
            }
            else
            {
                Console.WriteLine("It is not Monday");
            }
        }
    }
}
