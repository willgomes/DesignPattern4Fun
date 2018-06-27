using DP4F.Common.Results;
using DP4F.Product;

namespace DP4F.StrategyPattern.Strategy.Transport
{
    public class TotalExpress : ICalculateStrategy
    {
        private readonly double transportTax = 0.15;

        ItemResult ICalculateStrategy.Calculate(Item item)
        {
            return new ItemResult()
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                Quantity = item.Quantity,
                TransportTax = transportTax,
                Total = CalculateItem(item.Quantity, item.Price)
            };
        }


        private double CalculateItem(int quantity, double price)
        {
            return ((price * quantity) + transportTax);
        }

    }
}
