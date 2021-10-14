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
            var sortingAlgorithm = AlgorithmFactory
                            .Instance
                            .GetSortingAlgorithm(algorithm);

            if (sortingAlgorithm == null)
                return (-1, -1);

            Stopwatch stopwatch = Stopwatch.StartNew();
            sortingAlgorithm.SortArray(numbers);
            stopwatch.Stop();
            return (stopwatch.ElapsedTicks, stopwatch.ElapsedMilliseconds);
        }
    }
}