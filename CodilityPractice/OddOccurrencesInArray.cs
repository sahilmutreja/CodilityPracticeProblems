using System.Collections;
using System.Linq;

namespace CodilityPractice
{
    class OddOccurrencesInArray
    {
        /// <summary>
        /// Finds all the elements in the array occurring odd number of time
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int[] A)
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
    }
}
