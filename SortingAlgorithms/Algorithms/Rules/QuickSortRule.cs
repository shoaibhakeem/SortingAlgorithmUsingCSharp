using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
