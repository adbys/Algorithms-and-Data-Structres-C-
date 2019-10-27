using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            RecursiveSort(array, 0, array.Length - 1);
        }

        public static void RecursiveSort<T>(T[] array, int ini, int fin) where T : IComparable
        {
            if(ini >= fin)
            {
                return;
            }

            int pivotIndex = ini;
            int i = ini + 1;
            int j = fin;

            while(i < j)
            {
                while(array[j].CompareTo(array[pivotIndex]) > 0 && j > ini)
                {
                    j--;
                }

                while(array[i].CompareTo(array[pivotIndex]) < 0 && i < fin)
                {
                    i++;
                }

                if(i != j && i <= j)
                {
                    ArrayService.Swap(array, i, j);
                }
            }
            if(array[pivotIndex].CompareTo(array[j]) > 0)
            {
                ArrayService.Swap(array, j, pivotIndex);
            }

            int newFin = j - 1;
            int newIni = j + 1;
            RecursiveSort(array, ini, newFin);
            RecursiveSort(array, newIni, fin);

        }
    }
}
