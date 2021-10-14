using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms.Algorithms.Rules
{
    public class BubbleSortRule : ISortRule
    {
        public ISort Execute() => new BubbleSort();

        public bool Trigger(SortingAlgorithm sortingAlgorithm)
            => sortingAlgorithm == SortingAlgorithm.BubbleSort;
    }
}