using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = array.Length - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if(array[j].CompareTo(array[j + 1]) > 0)
                    {
                        ArrayService.Swap(array, j, (j + 1));
                    }
                }
            }
        }
    }
}
