using System;

namespace CodilityPractice
{
    class MaxOccurrenceInArray
    {
        //static void Main(string[] args)
        //{
        //    MaxOccurrenceInArray c = new MaxOccurrenceInArray();
        //    int[] A = { 1, 2 };
        //    Console.WriteLine(c.solution(3, A));
        //    Console.Read();
        //}

        public int solution(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M + 1];
            for (int i = 0; i <= M; i++)
                count[i] = 0;
            int maxOccurence = 0;
            int index = -1;
            for (int i = 0; i < N; i++)
            {
                if (count[A[i]] > 0)
                {
                    int tmp = count[A[i]];
                    if (tmp > maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = i;
                    }
                    count[A[i]] = tmp + 1;
                }
                else
                {
                    count[A[i]] = 1;
                }
            } 
            return A[index];
        }

        private void PrintArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i]);
        }

        public int Sum(int[] a)
        {
            int sum = 0;
            foreach (int n in a)
                sum += n;
            return sum;
        }

    }
}
