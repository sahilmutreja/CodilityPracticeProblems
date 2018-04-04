using System;

namespace CodilityPractice
{
    class FlipCoinMaxCount:Base
    {   
        public int solution(int[] A)
        {
            int n = A.Length;
            int result = 1, tempr=1;
            for (int i = 0; i < n - 1; i++)
            {
                if (A[i] == A[i + 1])
                    tempr = tempr + 1;
                else tempr = 0;
                result = (result < tempr)? tempr:result;
            }
            Console.WriteLine("result: " + result);
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                if (i > 0)
                {
                    if (A[i - 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }
                if (i < n - 1)
                {
                    if (A[i + 1] != A[i])
                        count = count + 1;
                    else
                        count = count - 1;
                }
                Console.WriteLine("Previousr: {0}, count: {1}, i: {2}", r,count,i);

                r = Math.Max(r, count);
                Console.WriteLine("Finalr: " + r);
            }
            return result + r;
        }
    }
}
