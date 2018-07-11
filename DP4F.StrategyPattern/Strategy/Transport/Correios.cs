using DP4F.Common.Results;
using DP4F.Product;

namespace DP4F.StrategyPattern.Strategy.Transport
{
    public class Correios : ICalculateStrategy
    {
        private readonly double transportTax = 0.80;

        ItemResult ICalculateStrategy.Calculate(IItem item)
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
            if (quantity > 0 && price > 0)
            {
                return ((price * quantity) + transportTax);
            }
            return 0;
        }
    }
}
