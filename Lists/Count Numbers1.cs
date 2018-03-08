using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Count_Numbers1
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;

                for (int q = 0; q < numbers.Count-1; q++)
			    {
			     if (numbers[q] == numbers[q+1])
                  {
                    count++;
                  }
                 else
                  {
                     Console.WriteLine(numbers[q] + " -> " + count);
                     count = 1;
                 }
                      
                }
                Console.WriteLine(numbers[numbers.Count-1] + " -> " + count);
        }
    }
}
