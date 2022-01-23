namespace XpressUrl;

/// <inheritdoc cref="IUrlGenerator" />
public class UrlGenerator : IUrlGenerator
{
    public IUrlDomainBuilder WwwDot(string urlSection)
    {
        return new UrlBuilder($"www.{urlSection}");
    }

    public IUrlDomainBuilder Http(string urlSection)
    {
        return new UrlBuilder($"http://{urlSection}");
    }

    public IUrlDomainBuilder Https(string urlSection)
    {
        return new UrlBuilder($"https://{urlSection}");
    }
}