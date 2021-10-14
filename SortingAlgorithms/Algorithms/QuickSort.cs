using System;

namespace SortingAlgorithms.Algorithms
{
    public class QuickSort : ISort
    {
        public void SortArray(int[] numbers)
        {
            PerformSort(numbers, 0, numbers.Length - 1); 
        }

        private void PerformSort(int[] numbers, int left, int right)

        {
            if (left < right)
            {
                int pivot = Partition(numbers, left, right);
                if (pivot > 1)
                    PerformSort(numbers, left, pivot - 1);
                if (pivot + 1 < right)
                    PerformSort(numbers, pivot + 1, right);
            }
        }

        private int Partition(int[] numbers, int left, int right)

        {

            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] > pivot)
                    right--;
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
