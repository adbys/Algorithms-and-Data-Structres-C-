using System;

namespace Algorithms_and_Data_Structures
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = (array.Length - 1); i > 0; i--)
            {
                T maxValue = array[i];
                int maxValueIndex = i;
                int j;
                for(j = 0; j < i; j++)
                {
                    if(array[j].CompareTo(maxValue) > 0)
                    {
                        maxValue = array[j];
                        maxValueIndex = j;
                    }

                }
                ArrayService.Swap(array, i, maxValueIndex);
            }
        }
    }
}
