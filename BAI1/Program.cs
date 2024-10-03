using System;
using System.Collections.Generic;

namespace BAI
{
    public class BAI_Afteken1
    {
        public static void Opdr1FilterList(List<int> lijst)
        {
            // Create a dictionary to count occurrences of each number
            Dictionary<int, int> countDict = new Dictionary<int, int>();

            foreach (int number in lijst)
            {
                if (countDict.ContainsKey(number))
                {
                    countDict[number]++;
                }
                else
                {
                    countDict[number] = 1;
                }
            }

            // Remove elements that appear only once
            lijst.RemoveAll(number => countDict[number] == 1);
        }

        public static Queue<int> Opdr2aQueue50()
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i <= 50; i++)
            {
                queue.Enqueue(i);
            }

            return queue;
        }

        public static Stack<int> Opdr2bStackFromQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();
                if (number % 4 == 0)
                {
                    stack.Push(number);
                }
            }

            return stack;
        }

        public static Stack<int> Opdr3RandomNumbers(int lower, int upper, int count)
        {
            Stack<int> stack = new Stack<int>();
            Dictionary<int, bool> uniqueNumbers = new Dictionary<int, bool>();
            Random random = new Random();

            while (stack.Count < count)
            {
                int number = random.Next(lower, upper + 1);
                if (!uniqueNumbers.ContainsKey(number))
                {
                    uniqueNumbers[number] = true;
                    stack.Push(number);
                }
            }

            return stack;
        }

        static void PrintEnumerable(IEnumerable<int> enu)
        {
            foreach (int i in enu)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> list;
            Queue<int> queue;
            Stack<int> stack;

            Console.WriteLine();
            Console.WriteLine("=== Opdracht 1 : FilterList ===");
            list = new List<int>() { 1, 3, 5, 7, 3, 8, 9, 5 };
            PrintEnumerable(list);
            Opdr1FilterList(list);
            PrintEnumerable(list);

            Console.WriteLine();
            Console.WriteLine("=== Opdracht 2 : Stack / Queue ===");
            queue = Opdr2aQueue50();
            PrintEnumerable(queue);
            stack = Opdr2bStackFromQueue(queue);
            PrintEnumerable(stack);

            Console.WriteLine();
            Console.WriteLine("=== Opdracht 3 : Random number ===");
            stack = Opdr3RandomNumbers(100, 150, 10);
            PrintEnumerable(stack);
            stack = Opdr3RandomNumbers(10, 15, 6);
            PrintEnumerable(stack);
            stack = Opdr3RandomNumbers(10_000, 50_000, 40_001);
        }
    }
}
