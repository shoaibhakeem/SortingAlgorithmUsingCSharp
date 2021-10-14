using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms.Algorithms.Rules
{
    public interface ISortRule
    {
        public bool Trigger(SortingAlgorithm sortingAlgorithm);

        public ISort Execute();
    }
}