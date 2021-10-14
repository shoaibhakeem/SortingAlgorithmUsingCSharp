using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms.Algorithms.Rules
{
    public class QuickSortRule : ISortRule
    {
        public ISort Execute() => new QuickSort();

        public bool Trigger(SortingAlgorithm sortingAlgorithm)
            => sortingAlgorithm == SortingAlgorithm.QuickSort;
    }
}