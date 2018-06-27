using DP4F.Common.Results;
using DP4F.Product;
using DP4F.StrategyPattern.Strategy;

namespace DP4F.StrategyPattern
{
    public class CalculateFreight
    {
        private ICalculateStrategy _strategy;

        public CalculateFreight(ICalculateStrategy strategy)
        {
            _strategy = strategy;
        }

        public ItemResult Calculate(Item item)
        {
            return _strategy.Calculate(item);
        }
    }
}
