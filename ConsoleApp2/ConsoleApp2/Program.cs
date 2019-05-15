using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var smallest = GetSmallest(numbers, 3);
            foreach (var number in smallest)

            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
                list.Remove(min);
            }
            return min;
        }
        public static List<int> GetSmallest(List<int> list, int count)
        {
            var smallest = new List<int>();
            while (smallest.Count < count)
            {
                var min = GetSmallest(list);
                smallest.Add(min);
            }
            return smallest;
        }
    }

}