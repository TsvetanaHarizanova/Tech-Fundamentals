using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveNum = new List<int>();
            bool isTrue = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                if (numbers[i] > 0)
                {
                    positiveNum.Add(num);
                    isTrue = true;
                }
                
            }
            
            
            positiveNum.Reverse();

            if (isTrue)
            {
                Console.WriteLine(string.Join(" ", positiveNum));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
