using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_number_sum
{
    internal static class Soution1
    {
        /// <summary>
        /// Input = [3, 5, -4, 8, 11, 1, -1, 6]
        /// Target = 10
        /// O(n) Time | O(n) Space
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            HashSet<int> verifiedData = new HashSet<int>();
            for(int i = 0; i < array.Length; i++)
            {
                var remaining = targetSum - array[i];
                if (array[i]+remaining == targetSum && verifiedData.Contains(remaining))
                {
                    return new int[2] { array[i],remaining};
                }
                verifiedData.Add(array[i]);
            }
            return new int[0];
        }

        /// <summary>
        /// Input = [3, 5, -4, 8, 11, 1, -1, 6]
        /// Target = 10
        /// O(nlog(n)) Time | O(1) Space
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static int[] TwoNumberSum1(int[] array, int targetSum)
        {
            Array.Sort(array);
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var result = array[left] + array[right];
                if (result == targetSum)
                {
                    return new int[2] { array[left], array[right] };
                }else if (result > targetSum)
                {
                    right--;
                }else if(result < targetSum)
                {
                    left++;
                }
            }
            return new int[0];
        }
    }
}
