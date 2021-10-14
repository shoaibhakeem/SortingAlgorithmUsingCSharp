using System;

namespace SortingAlgorithms
{
    public static class InputDataHandler
    {
        public static int[] FillArray(int count)
        {
            int[] numbers = new int[count];
            Console.WriteLine($"Enter {count} numbers to be sorted");
            for (int index = 0; index < count; index++)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numbers[index] = number;
                }
                else
                {
                    Console.WriteLine(EnumsAndConstants.InvalidEntry);
                    index--;
                }
            }
            return numbers;
        }

        public static string GetInputForCount()
        {
            Console.WriteLine(EnumsAndConstants.ApplicationEntryText);
            return Console.ReadLine();
        }
    }
}