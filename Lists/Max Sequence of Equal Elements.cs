﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
         
            int count = 1;
            int maxCount = 0;
            int maxNum = 0;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNum = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNum = numbers[i];
                }

            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum + " ");
            }
        }
    }
}
