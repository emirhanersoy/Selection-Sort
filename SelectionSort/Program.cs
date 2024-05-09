using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {

        public static void selectionSort(int[] a)
        {

            int i, j, min, temp;

            for (i = 0; i < a.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }

                }


                temp = a[min];
                a[min] = a[i];
                a[i] = temp;
            }

        }

        static void Main(string[] args)
        {
            int[] array = { 4, 1, 5, 2, 7, 8, 12, 63, 23, 574, 12, 697, 142, 435, 867, 2354735, 354, 214, 346, 214, 754, 235, 746754, 967543, 73, 566243, 54, 4537, 345, 78, 436, 6, 8563, 463, 235, 7245, 1346, 2475, 364, 48, 643, 47588, 3243 };


            Console.WriteLine("Sıralamadan önceki array: \n");
            foreach(int i in array)
            {
                
                Console.Write(i+" ");
            }

            Console.WriteLine(" \n\n\nSıralamadan sonraki array: \n");
            selectionSort(array);
            foreach(int i in array)
            {
                Console.Write(i+" ");
            }

            Console.ReadKey();

        }
    }
}
