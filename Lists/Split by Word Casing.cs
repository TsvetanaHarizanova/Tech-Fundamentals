using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new[] { '|', ' ', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> specialCh = new List<string>();
            int countLower = 0;
            int countUpper = 0;
            int countSpecial = 0;
            foreach (var q in words)
            {
                foreach (var i in q)
                {
                    if (char.IsLower(i))
                    {
                        countLower++;
                    }
                    else if (char.IsUpper(i))
                    {
                        countUpper++;
                    }
                    else
                    {
                        countSpecial++;
                    }

                }
                if (countLower > 0 && countUpper == 0 && countSpecial == 0)
                {
                    lower.Add(q);
                }
                else if (countLower == 0 && countUpper > 0 && countSpecial == 0)
                {
                    upper.Add(q);
                }
                else
                {
                    specialCh.Add(q);
                }
                countLower = 0;
                countUpper = 0;
                countSpecial = 0;

            }
            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lower));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", specialCh));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upper));


        }
    }
}
