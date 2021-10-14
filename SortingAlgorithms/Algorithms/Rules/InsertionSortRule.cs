using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms.Algorithms.Rules
{
    public class InsertionSortRule : ISortRule
    {
        public ISort Execute() => new InsertionSort();

        public bool Trigger(SortingAlgorithm sortingAlgorithm)
            => sortingAlgorithm == SortingAlgorithm.InsertionSort;
    }
}
