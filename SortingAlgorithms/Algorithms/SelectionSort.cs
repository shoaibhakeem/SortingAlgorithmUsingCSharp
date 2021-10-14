namespace SortingAlgorithms.Algorithms
{
    public class SelectionSort : ISort
    {
        public void GetSortedArray(int[] numbers)
        {
            int count = numbers.Length;

            for (int i = 0; i < count - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (numbers[j] < numbers[smallest])
                        smallest = j;
                }

                int temp = numbers[smallest];
                numbers[smallest] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}