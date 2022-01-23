using Microsoft.Extensions.DependencyInjection;

namespace XpressUrl.DependencyInjection;

public static class XpressUrlRegistration
{
    /// <summary>
    /// Add XpressUrl to a service collection
    /// </summary>
    /// <param name="serviceCollection">The service collection to add XpressUrl to</param>
    /// <returns>The service collection that XpressUrl is added to</returns>
    public static IServiceCollection AddXpressUrl(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IUrlGenerator, UrlGenerator>();

        return serviceCollection;
    }
}
