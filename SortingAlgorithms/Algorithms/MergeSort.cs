namespace SortingAlgorithms.Algorithms
{
    public class MergeSort : ISort
    {
        public void SortArray(int[] numbers)
        {
            PerformSort(numbers, 0, numbers.Length - 1);
        }

        private void PerformSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int m = leftIndex + (rightIndex - leftIndex) / 2;

                PerformSort(arr, leftIndex, m);
                PerformSort(arr, m + 1, rightIndex);
                MergeArrays(arr, leftIndex, m, rightIndex);
            }
        }

        private void MergeArrays(int[] numbers, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftArrayCount = middleIndex - leftIndex + 1;
            int rightArrayCount = rightIndex - middleIndex;

            int[] leftArray = new int[leftArrayCount];
            int[] rightArray = new int[rightArrayCount];
            int i, j;

            for (i = 0; i < leftArrayCount; ++i)
                leftArray[i] = numbers[leftIndex + i];

            for (j = 0; j < rightArrayCount; ++j)
                rightArray[j] = numbers[middleIndex + 1 + j];

            i = 0;
            j = 0;

            int k = leftIndex;
            while (i < leftArrayCount && j < rightArrayCount)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    numbers[k] = leftArray[i];
                    i++;
                }
                else
                {
                    numbers[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArrayCount)
            {
                numbers[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightArrayCount)
            {
                numbers[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}