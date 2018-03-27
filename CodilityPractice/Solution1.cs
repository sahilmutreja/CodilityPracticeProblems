using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary> 
/// Authtor: Sahil Mutreja
/// Date: March 26, 2018
/// </summary>
namespace CodilityPractice
{
    class Solution1
    {
        static void Main(string[] args)
        {

            int[] A = {2, 1, 1 };
            Console.WriteLine(new Solution1().OddOccurrencesInArray(A));
            Console.Read();
        }

        /// <summary>
        /// Finds all the elements in the array occurring odd number of time
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int OddOccurrencesInArray(int[] A)
        {
            //Solution Using MAP
            //Dictionary<int, int> map = new Dictionary<int, int>();
            //foreach (int x in A)
            //{
            //    if (map.ContainsKey(x))
            //        map[x] = map[x] + 1;
            //    else
            //        map[x] = 1;
            //}

            ////IEnumerable<KeyValuePair<int, int>> valuePair = map.Where(p => p.Value == 1);
            //IEnumerable<KeyValuePair<int, int>> valuePair =  from obj in map where obj.Value == 1 select obj;
            //return valuePair.FirstOrDefault().Key;

            //Solution Using Arraylist
            ArrayList oddValue = new ArrayList();
            foreach (int x in A)
            {
                if (oddValue.Contains(x))
                    oddValue.Remove(x);
                else
                    oddValue.Add(x);
            }
            return oddValue.Count > 0 ? (int)oddValue[0] : 0;
        }
          
        /// <summary>
        /// CyclicRotation: Rotate an array to the right by a given number of steps
        /// </summary>
        /// <param name="A">Array</param>
        /// <param name="k">Number of steps</param>
        /// <returns></returns>
        public int[] rotateArray(int[] A, int rotate)
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

        /// <summary>
        /// BinaryGap: Find longest sequence of zeros in binary representation of an integer.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int CountGap(int N)
        {
            int finalGap = 0, currentGap = 0;
            string binConversion = Convert.ToString(N, 2);
            Console.WriteLine("Decimal Number: {0}, Binary Number: {1}", N, binConversion);

            for (int i = 0; i < binConversion.Length; i++)
            {
                if (binConversion[i].Equals('1'))
                {
                    if (finalGap < currentGap)
                        finalGap = currentGap;
                    currentGap = 0;
                }
                else if (binConversion[i].Equals('0'))
                    currentGap++;

            }
            return finalGap;
        }

        private static void PrintArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i]);
        }

    }


}
