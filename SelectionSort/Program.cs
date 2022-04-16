using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = random.Next(0, 9);
            }

            SelectionSort.Sort(numbers);

            Console.Write("Selection Sort");
            Console.WriteLine(" ");
            Console.WriteLine(string.Join(" | ", numbers));
        }
    }
}
