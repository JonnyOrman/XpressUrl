using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Xunit;

namespace XpressUrl.DependencyInjection.Testing.UnitTests;

public class GivenXpressUrlRegistration
{
    public class WhenXpressUrlIsAddedToServices : GivenXpressUrlRegistration
    {
        [Fact]
        public void ItAddsTheXpressUrlServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddXpressUrl();

            Assert.Equal(1, serviceCollection.Count);
            Assert.NotNull(serviceCollection.Single(x => x.ServiceType == typeof(IUrlGenerator)));
        }
    }
}