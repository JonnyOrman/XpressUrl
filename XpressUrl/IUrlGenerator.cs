namespace XpressUrl;

/// <summary>
/// Generates URL builders
/// </summary>
public interface IUrlGenerator
{
    /// <summary>
    /// Generates a builder for a WWW URL with the provided domain beginning
    /// </summary>
    /// <param name="domainBeginning">The beginning of the domain</param>
    /// <returns>The generated URL builder</returns>
    IUrlDomainBuilder WwwDot(string domainBeginning);

    /// <summary>
    /// Generates a builder for a HTTP URL with the provided domain beginning
    /// </summary>
    /// <param name="domainBeginning">The beginning of the domain</param>
    /// <returns>The generated URL builder</returns>
    IUrlDomainBuilder Http(string domainBeginning);

    /// <summary>
    /// Generates a builder for a HTTPS URL with the provided domain beginning
    /// </summary>
    /// <param name="domainBeginning">The beginning of the domain</param>
    /// <returns>The generated URL builder</returns>
    IUrlDomainBuilder Https(string domainBeginning);
}
