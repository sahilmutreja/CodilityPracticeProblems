using System;
using System.Collections.Generic;

namespace CodilityPractice
{
    class TapeEquilibrium:Base
    {
        /// <summary>
        ///  The absolute difference between the sum of the first part and the sum of the second part.
        /// </summary>
        /// <param name="A">Array A</param>
        /// <returns></returns>
        public int solution(int[] A)
        {
            int temp = 0;
            List<int> list = new List<int>(A);
            int totalSum = Sum(A);
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                temp = temp + i;
                result.Add(Math.Abs((totalSum - temp) - temp));
            }
            result.Sort();
            return result[0];
        }
    }
}
