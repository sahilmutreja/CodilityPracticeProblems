using System;

namespace CodilityPractice
{
    class MissingNumberInArray
    {
        public int solution(int[] A)
        {
            int actualSum = 0, totalSum = 0, previousNumber = 0, answer;
            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (i > 0)
                {
                    if (previousNumber == A[i])
                        return 0;
                }
                actualSum += A[i];
                previousNumber = A[i];
            }
            for (int i = 1; i <= A.Length; i++)
                totalSum += i;
            int difference = totalSum - actualSum;
            return (difference == 0) ? 1 : 0;
        }
    }
}
