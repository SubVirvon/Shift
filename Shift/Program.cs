using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 10;
            int[] array = new int[arrayLength];
            int shiftMagnitude;

            Console.Write("Массив: ");

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = i;
                Console.Write(array[i] + " ");
            }

            Console.Write("\nВведите величину сдвига: ");
            shiftMagnitude = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < shiftMagnitude; i++)
            {
                int tempNumber = array[array.Length - 1];

                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = tempNumber;
            }

            Console.Write("Массив: ");

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
