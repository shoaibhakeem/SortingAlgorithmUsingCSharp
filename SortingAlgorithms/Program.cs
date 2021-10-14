using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isExit;
            do
            {
                string numbersCount = InputDataHandler.GetInputForCount();
                if (int.TryParse(numbersCount, out int count))
                {
                    AlgorithmExecuter.Execute(InputDataHandler.FillArray(count));
                }
                else if (numbersCount != EnumsAndConstants.TerminationText)
                {
                    Console.WriteLine(EnumsAndConstants.InvalidEntry);
                }

                isExit = numbersCount == EnumsAndConstants.TerminationText;
            }
            while (!isExit);
            OutputDataHandler.Farewell();
        }
    }
}