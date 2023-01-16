using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted_squared_array
{
    internal static class Solutions
    {
        public static int[] Solution1(int[] array)
        {
            // Write your code here.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i];
            }
            Array.Sort(array);
            return array;
        }
        public static int[] Solution2(int[] array)
        {
            var res = new int[array.Length];
            var counter = array.Length - 1;
            var fi = 0;
            var li = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[fi]) > Math.Abs(array[li]))
                {
                    res[counter - i] = array[fi] * array[fi];
                    fi++;
                }
                else
                {
                    res[counter - i] = array[li] * array[li];
                    li--;
                }
            }
            return res;
        }
    }
}
