using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    internal class Program
    {
        static void fillArray(bool[] array)
        {
            for (int i = 0; i < 100; i++) 
            {
                array[i] = true;
            }
        }

        static void printArraay(bool[] array)
        {
            for(int i = 0;i < array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }
        }
        static void checkForPrimeNumbers(bool[] array)
        {
            array[0] = false;
            array[1] = false;
            for (int i = 2; i < Math.Sqrt(array.Length); i++)
            {
                for(int j = 2; j < array.Length; j++)
                {
                    if(j !=i && j % i == 0)
                    {
                        array[j] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            bool[] arrayOfNumbers = new bool[100];
            fillArray(arrayOfNumbers);
            checkForPrimeNumbers(arrayOfNumbers);
            printArraay(arrayOfNumbers);

        }
    }
}
