using SortingAlgorithms.Algorithms.Rules;
using System.Collections.Generic;
using System.Linq;
using static SortingAlgorithms.EnumsAndConstants;

namespace SortingAlgorithms.Algorithms
{
    public class AlgorithmFactory
    {
        private static volatile AlgorithmFactory _instance = null;
        private static readonly object _objectlock = new();

        private readonly List<ISortRule> _rules;

        private AlgorithmFactory()
        {
            _rules = new List<ISortRule>()
            {
                new SelectionSortRule(),
                new BubbleSortRule()
            };
        }

        public static AlgorithmFactory Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_objectlock)
                    {
                        if (_instance is null)
                            _instance = new AlgorithmFactory();
                    }
                }
                return _instance;
            }
        }

        public ISort GetSortingAlgorithm(SortingAlgorithm sortingAlgorithm) => _rules
            .FirstOrDefault(x => x.Trigger(sortingAlgorithm))
            ?.Execute();
    }
}