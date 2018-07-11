using DP4F.Common.Results;
using DP4F.Product;
using DP4F.StrategyPattern.ObjectValues;
using DP4F.StrategyPattern.Strategy;
using DP4F.StrategyPattern.Strategy.Transport;
using Moq;
using Xunit;

namespace DP4F.StrategyPatternTests
{
    [Collection("Stratetgy Pattern")]
    public class StrategyPatternTests
    {
        [Fact]
        public void MustReturnTaxFromCorreios()
        {
            Mock<IItem> mock = new Mock<IItem>();
            IItem item = mock.Object;

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.CORREIOS);

            ItemResult itemResult = availableStrategy.Calculate(item);
            Assert.Equal(0.80, itemResult.TransportTax);
        }

        [Fact]
        public void MustReturnTaxFromJadLog()
        {
            Mock<IItem> mock = new Mock<IItem>();
            IItem item = mock.Object;

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.JADLOG);
            ItemResult itemResult = availableStrategy.Calculate(item);
            Assert.Equal(0.45, itemResult.TransportTax);
        }

        [Fact]
        public void MustReturnTaxFromTotalExpress()
        {
            Mock<IItem> mock = new Mock<IItem>();
            IItem item = mock.Object;

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.TOTALEXPRESS);
            ItemResult itemResult = availableStrategy.Calculate(item);
            Assert.Equal(0.15, itemResult.TransportTax);
        }

        [Fact]
        public void MustReturnTaxFromFedex()
        {
            Mock<IItem> mock = new Mock<IItem>();
            IItem item = mock.Object;

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.FEDEX);
            ItemResult itemResult = availableStrategy.Calculate(item);

            Assert.Equal(0.65, itemResult.TransportTax);
        }

        [Fact]
        public void ReturnMustBeZeroFromCorreios()
        {
            Mock<IItem> mock = new Mock<IItem>();

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.CORREIOS);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total == 0);
        }

        [Fact]
        public void ReturnMustBeZeroFromFedex()
        {
            Mock<IItem> mock = new Mock<IItem>();

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.FEDEX);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total == 0);
        }

        [Fact]
        public void ReturnMustBeZeroFromJadLog()
        {
            Mock<IItem> mock = new Mock<IItem>();

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.JADLOG);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total == 0);
        }

        [Fact]
        public void ReturnMustBeZeroFromTotalExpress()
        {
            Mock<IItem> mock = new Mock<IItem>();

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.TOTALEXPRESS);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total == 0);
        }

        [Fact]
        public void ReturnMustBeGreaterThanZeroFromCorreios()
        {
            Mock<IItem> mock = new Mock<IItem>();

            mock.SetupProperty(item => item.Quantity, 5);
            mock.SetupProperty(item => item.Price, 125.5);

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.CORREIOS);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total > 0);
        }

        [Fact]
        public void ReturnMustBeGreaterThanZeroFromFedex()
        {
            Mock<IItem> mock = new Mock<IItem>();
            mock.SetupProperty(item => item.Quantity, 5);
            mock.SetupProperty(item => item.Price, 125.5);

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.FEDEX);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total > 0);
        }

        [Fact]
        public void ReturnMustBeGreaterThanZeroFromJadLog()
        {
            Mock<IItem> mock = new Mock<IItem>();
            mock.SetupProperty(item => item.Quantity, 5);
            mock.SetupProperty(item => item.Price, 125.5);

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.JADLOG);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total > 0);
        }

        [Fact]
        public void ReturnMustBeGreaterThanZeroFromTotalExpress()
        {
            Mock<IItem> mock = new Mock<IItem>();
            mock.SetupProperty(item => item.Quantity, 5);
            mock.SetupProperty(item => item.Price, 125.5);

            ICalculateStrategy availableStrategy = TransportFactory.GetAvailableStrategy(AvailableTransports.TOTALEXPRESS);
            ItemResult itemResult = availableStrategy.Calculate(mock.Object);

            Assert.True(itemResult.Total > 0);
        }

    }
}
