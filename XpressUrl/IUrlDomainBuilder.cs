namespace XpressUrl;

/// <summary>
/// Builds the domain part of a URL
/// </summary>
public interface IUrlDomainBuilder : IUrlPathBuilder
{
    /// <summary>
    /// Appends a domain section to the URL
    /// </summary>
    /// <param name="domainSection">The domain section to append to the URL</param>
    /// <returns>The builder for the URL being built</returns>
    IUrlDomainBuilder Dot(string domainSection);
}
