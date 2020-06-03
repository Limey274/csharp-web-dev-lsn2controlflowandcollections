using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");

            // List<string> newList = new List<string>();

            
                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(3);
                numbers.Add(4);
                numbers.Add(5);
                numbers.Add(6);
                numbers.Add(7);
                numbers.Add(8);
                numbers.Add(9);
                numbers.Add(10);

            Console.WriteLine(evenSum(numbers));           

           //int sum = numbers.Sum();
            Console.WriteLine(numbers.ToArray() );
            numbers.ForEach(Console.WriteLine);

        }

        static int evenSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {


                if (numbers[i] % 2 == 0)
                {

                    //Console.WriteLine(numbers[i]);
                    sum += numbers[i];
                }
              
            }
            return sum;
        
        }



    }
}
