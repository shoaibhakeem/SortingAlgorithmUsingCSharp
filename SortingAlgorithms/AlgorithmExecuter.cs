using SortingAlgorithms.Algorithms;
using System;
using System.Diagnostics;
using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms
{
    public static class AlgorithmExecuter
    {
        public static void Execute(int[] numbers)
        {
            foreach (SortingAlgorithm algorithm in Enum.GetValues(typeof(SortingAlgorithm)))
            {
                int[] numCopy = new int[numbers.Length];
                numbers.CopyTo(numCopy, 0);
                (long elapsedTicks, long elapsedTime) = MonitorAlgorithm(numCopy, algorithm);
                OutputDataHandler.PrintResults(elapsedTicks, elapsedTime, algorithm, numCopy);
            }
        }

        private static (long elapsedTicks, long elapsedTimeInMilliseconds) MonitorAlgorithm(int[] numbers, SortingAlgorithm algorithm)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ExecuteAlgorithm(numbers, algorithm);
            stopwatch.Stop();
            return (stopwatch.ElapsedTicks, stopwatch.ElapsedMilliseconds);
        }

        private static void ExecuteAlgorithm(int[] numbers, SortingAlgorithm algorithm)
        {
            AlgorithmFactory
                .Instance
                .GetSortingAlgorithm(algorithm)
                ?.GetSortedArray(numbers);
        }
    }
}