using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures
{
    class Program
    {
     
        //Arrays are element of fixed size;
        //It has three types: single dimension array (row of elements)
        // multi dimension arrays (matrix of elements)
        //jagged arrays (array with rows of different size)
        static void Main(string[] args)
        {
            int[] simpleEmptyArray = new int[5];
            int[,] emptyMatrix = new int[5, 5];
            int[,] multiplicationTable = new int[10, 10];

            //GetLength 0 get the size of the first dimesion of matrix
            for(int i = 0; i < multiplicationTable.GetLength(0); i++)
            {
                //GetLength 1 get the size of the second dimension of matrix
                for(int j = 0; j < multiplicationTable.GetLength(1); j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            for(var i = 0; i < multiplicationTable.GetLength(0); i++)
            {
                for(var j = 0; j < multiplicationTable.GetLength(1); j++)
                {
                    Console.Write("{0,4}", multiplicationTable[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("========================== Selection Sort =======================");
            int[] array = new int[] { 99, 8, 0, -15, -85, 25, 32 };
            Console.WriteLine(string.Join(" ", array));
            SelectionSort.Sort(array);
            Console.WriteLine(string.Join(" ", array));

            Console.WriteLine("========================== Insertion Sort =======================");
            array = new int[] { 99, 8, 0, -15, -85, 25, 32 };
            Console.WriteLine(string.Join(" ", array));
            InsertionSort.Sort(array);
            Console.WriteLine(string.Join(" ", array));


            Console.WriteLine("========================== Bubble Sort ==========================");
            array = new int[] { 99, 8, 0, -15, -85, 25, 32 };
            Console.WriteLine(string.Join(" ", array));
            BubbleSort.Sort(array);
            Console.WriteLine(string.Join(" ", array));

            Console.WriteLine("========================== Quick Sort ==========================");
            array = new int[] { 99, 8, 0, -15, -85, 25, 32 };
            Console.WriteLine(string.Join(" ", array));
            QuickSort.Sort(array);
            Console.WriteLine(string.Join(" ", array));

            Console.ReadLine();
        }
    }
}
