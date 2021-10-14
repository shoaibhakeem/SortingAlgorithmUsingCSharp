using System;
using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms
{
    public static class OutputDataHandler
    {
        public static void PrintList(int[] numbers)
        {
            Console.WriteLine(SortedMessageText);
            foreach (var number in numbers)
            {
                Console.Write($" {number} ");
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static void Farewell()
        {
            Console.WriteLine(FarewellMessage);
            Console.ReadKey();
        }

        private static void PrintPerformanceStatistics(long elapsedTicks, long elapsedTimeInMilliseconds, SortingAlgorithm algorithm)
        {
            Console.WriteLine($@" Performance of {algorithm} algorithm.
                    Ticks Elaped : {elapsedTicks} ,
                    Elapsed Time In Milliseconds : {elapsedTimeInMilliseconds} {Environment.NewLine}");
        }

        public static void PrintResults(long elapsedTicks, long elapsedTimeInMilliseconds, SortingAlgorithm algorithm, int[] numbers)
        {
            PrintPerformanceStatistics(elapsedTicks, elapsedTimeInMilliseconds, algorithm);
            PrintList(numbers);
        }
    }
}