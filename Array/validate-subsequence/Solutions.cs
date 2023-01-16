using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validate_subsequence
{
    internal static class Solutions
    {
        /// <summary>
        /// O(n) time | O(1) space - where n is the length of the array
        /// </summary>
        /// <param name="array">[5, 1, 22, 25, 6, -1, 8, 10]</param>
        /// <param name="sequence">[1, 6, -1, 10]</param>
        /// <returns></returns>
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            var sequenceCount = 0;
            for (int i = 0; i < array.Count && sequenceCount != sequence.Count; i++)
            {
                if (array[i] == sequence[sequenceCount])
                    sequenceCount++;
            }
            return sequenceCount == sequence.Count;
        }
    }
}
