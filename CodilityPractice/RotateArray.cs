using System.Collections.Generic;

namespace CodilityPractice
{
    class RotateArray
    {
        /// <summary>
        /// CyclicRotation: Rotate an array to the right by a given number of steps
        /// </summary>
        /// <param name="A">Array</param>
        /// <param name="k">Number of steps</param>
        /// <returns></returns>
        public int[] solution(int[] A, int rotate)
        {
            //Method 1
            //if (A == null || A.Length == 0)
            //    return null;
            //int[] result = new int[A.Length];
            //int arrayLength = A.Length;
            //int moveBy = k % arrayLength;
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    int tmp = i + moveBy;
            //    if (tmp > arrayLength - 1)
            //    {
            //        tmp = tmp - arrayLength;
            //    }
            //    result[tmp] = A[i];
            //}
            //return result;

            //Method 2
            Queue<int> q = new Queue<int>(A);
            Stack<int> s;
            while (rotate > 0)
            {
                s = new Stack<int>(q);
                int x = s.Pop();
                s = new Stack<int>(s);
                s.Push(x);
                q = new Queue<int>(s);
                rotate--;
            }
            return q.ToArray();
        }
    }
}
