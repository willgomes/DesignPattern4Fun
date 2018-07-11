using DP4F.Common.Results;
using DP4F.Product;

namespace DP4F.StrategyPattern.Strategy
{
    public interface ICalculateStrategy
    {
        ItemResult Calculate(IItem item);
    }
}
