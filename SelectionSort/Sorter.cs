using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class Sorter
    {
        private static void swap(int[] array, int newPosition, int currentPositioin)
        {
            var temp = array[newPosition];
            array[newPosition] = array[currentPositioin];
            array[currentPositioin] = temp;
        }
        public static int[] DoSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        swap(array, j, i);
                    }
                }
            }
            return array; 
        }
    }
}
