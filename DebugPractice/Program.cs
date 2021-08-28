using System;
using System.Collections.Generic;

namespace DebugPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1, 2};
            List<int> smallests = GetSmallests(numbers, 3);

            foreach (int number in smallests)
            {
                // expected output "1, 2, 3, 4, 5, 6"
                Console.WriteLine(number);
            }
        }


        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (count > list.Count)
            {
                throw new ArgumentOutOfRangeException("count", "count is greater than number of elements in list");
            }

            List<int> smallests = new List<int>();
            List<int> bufferList = new List<int>(list);

                while (smallests.Count < count)
                {
                    int min = GetSmallest(bufferList);
                    smallests.Add(min);
                    bufferList.Remove(min);
                }
            return smallests;
        }


        public static int GetSmallest(List<int> list)
        {
            // assumes first number is smallest
            int min = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }
    }
}
