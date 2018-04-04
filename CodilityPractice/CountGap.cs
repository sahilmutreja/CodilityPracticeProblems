using System;

namespace CodilityPractice
{
    class CountGap
    {

        /// <summary>
        /// BinaryGap: Find longest sequence of zeros in binary representation of an integer.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int solution(int N)
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
    }
}
