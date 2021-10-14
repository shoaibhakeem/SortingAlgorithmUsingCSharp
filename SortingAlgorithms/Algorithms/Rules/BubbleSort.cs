namespace SortingAlgorithms.Algorithms.Rules
{
    public class BubbleSort : ISort
    {
        public void GetSortedArray(int[] numbers)
        {
            int i, j, temp;
            int count = numbers.Length;
            bool swapped;
            for (i = 0; i < count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}
