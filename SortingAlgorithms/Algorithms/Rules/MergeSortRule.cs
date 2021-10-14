using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms.Algorithms.Rules
{
    public class MergeSortRule : ISortRule
    {
        public ISort Execute() => new MergeSort();

        public bool Trigger(SortingAlgorithm sortingAlgorithm)
            => sortingAlgorithm == SortingAlgorithm.MergeSort;
    }
}