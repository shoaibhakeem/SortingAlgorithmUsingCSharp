using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms.Algorithms.Rules
{
    public class SelectionSortRule : ISortRule
    {
        public ISort Execute() => new SelectionSort();

        public bool Trigger(SortingAlgorithm sortingAlgorithm)
            => sortingAlgorithm == SortingAlgorithm.SelectionSort;
    }
}