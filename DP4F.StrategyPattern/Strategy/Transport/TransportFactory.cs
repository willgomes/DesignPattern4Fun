using System;
using System.Linq;
using System.Reflection;

namespace DP4F.StrategyPattern.Strategy.Transport
{
    public class TransportFactory
    {
        public static ICalculateStrategy GetAvailableStrategy(string transportName)
        {
            return Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(type => typeof(ICalculateStrategy).IsAssignableFrom(type) && type.IsClass && type.Name.Equals(transportName))
                                   .Select(type => Activator.CreateInstance(type))
                                   .Cast<ICalculateStrategy>()
                                   .First();

        }
    }
}
