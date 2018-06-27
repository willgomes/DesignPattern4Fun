using DP4F.Common.Results;
using DP4F.Product;
using DP4F.StrategyPattern;
using DP4F.StrategyPattern.Strategy.Transport;
using Xunit;

namespace DP4F.StrategyPatternTests
{
    [Collection("Stratetgy Pattern")]
    public class StrategyPatternTests
    {
        [Fact]
        public void MustReturnTaxFromCorreios()
        {
            Item item = new Item() {
                Id = 1,
                Name = "Produto A",
                Price = 15.00,
                Quantity = 5
            };

            CalculateFreight calculateFreight = new CalculateFreight(new Correios());
            ItemResult itemResult = calculateFreight.Calculate(item);

            Assert.Equal(0.80, itemResult.TransportTax);
        }

        [Fact]
        public void MustReturnTaxFromJadLog()
        {
            Item item = new Item()
            {
                Id = 1,
                Name = "Produto A",
                Price = 15.00,
                Quantity = 5
            };

            CalculateFreight calculateFreight = new CalculateFreight(new JadLog());
            ItemResult itemResult = calculateFreight.Calculate(item);

            Assert.Equal(0.45, itemResult.TransportTax);
        }

        [Fact]
        public void MustReturnTaxFromTotalExpress()
        {
            Item item = new Item()
            {
                Id = 1,
                Name = "Produto A",
                Price = 15.00,
                Quantity = 5
            };

            CalculateFreight calculateFreight = new CalculateFreight(new TotalExpress());
            ItemResult itemResult = calculateFreight.Calculate(item);

            Assert.Equal(0.15, itemResult.TransportTax);
        }


    }
}
