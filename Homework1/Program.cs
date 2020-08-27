using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = GetArray(arraySize);

            Console.WriteLine();
            ChangePrimeNumbers(array);

            Console.WriteLine();
            int max = GetMax(array);
            int min = GetMin(array);
            Console.WriteLine("Sum of min and max: {0}", min + max);
        }

        private static int[] GetArray(int arraySize)
        {
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        private static void ChangePrimeNumbers(int[] array)
        {
            bool isPrime;
            for (int i = 0; i < array.Length; i++)
            {
                isPrime = true;
                if (array[i] == 0 || array[i] == 1)
                {
                    isPrime = false;
                }
                else {
                    for (int j = 2; j <= Math.Sqrt(array[i]); j++)
                    {
                        if (array[i]%j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        array[i] = 0;
                    }
                }
            }
            PrintArray(array);
            Console.WriteLine();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Changed Array");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

       

        private static int GetMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        private static int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
