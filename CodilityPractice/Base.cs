using System;

namespace CodilityPractice
{
    class Base
    {

        protected static void PrintArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i]);
        }

        protected int Sum(int[] a)
        {
            int sum = 0;
            foreach (int n in a)
                sum += n;
            return sum;
        }
    }
}
