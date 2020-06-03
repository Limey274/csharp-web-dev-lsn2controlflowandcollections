using System;
using System.Threading;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello Arrays!");
             int[] array1 = new int[] { 1, 1, 2, 3, 5, 8 };

            //SINGLE NUMBERS
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("the numbers are " + array1[i]);

            }
            //ODD NUMBERS
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 != 0)
                {

                    Console.WriteLine("The odd numbers are " + array1[i] + " ");

                }
            }
        } 


    }
}
