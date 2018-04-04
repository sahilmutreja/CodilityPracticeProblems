using System;

namespace CodilityPractice
{
    class FrogJumps
    {
        /// <summary>
        /// Frog Jump minimal count of jumps needed to reach from point x to point y with d jumps
        /// </summary>
        /// <param name="x">Starting Point</param>
        /// <param name="y">Ending Point</param>
        /// <param name="d">Count of Jumps at one instance</param>
        /// <returns></returns>
        public static int solution(int x, int y, int d)
        {
            return (int)Math.Ceiling((y - x) / (float)d);
        }
    }
}
