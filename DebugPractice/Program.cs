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
                // expected output "1, 2"
                Console.WriteLine(number);
            }
        }


        public static List<int> GetSmallests(List<int> list, int count)
        {
            List<int> smallests = new List<int>();
            List<int> bufferList = new List<int>(list);

                while (smallests.Count < count)
                {
                    int min = GetSmallest(bufferList);
                    smallests.Add(min);
                    list.Remove(min);
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
