using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j >= 1 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    ArrayService.Swap(array, j, (j - 1));
                    j--;
                }
            }
        }
    }
}
