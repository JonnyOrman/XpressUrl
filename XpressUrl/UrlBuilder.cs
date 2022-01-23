using System.Text;

namespace XpressUrl;

/// <summary>
/// Builds a URL
/// </summary>
public class UrlBuilder : IUrlDomainBuilder, IUrlQueryStringKeyBuilder, IUrlQueryStringValueBuilder
{
    private readonly StringBuilder _stringBuilder;

    /// <summary>
    /// Constructs an instance of a URL builder
    /// </summary>
    /// <param name="start">The start of the URL being built</param>
    public UrlBuilder(string start)
    {
        _stringBuilder = new StringBuilder(start);
    }

    /// <inheritdoc cref="IUrlDomainBuilder.Dot" />
    public IUrlDomainBuilder Dot(string domainSection)
    {
        _stringBuilder.Append(".");
        _stringBuilder.Append(domainSection);

        return this;
    }

    /// <inheritdoc cref="IUrlPathBuilder.Slash" />
    public IUrlPathBuilder Slash(string pathSection)
    {
        _stringBuilder.Append("/");
        _stringBuilder.Append(pathSection);

        return this;
    }

    /// <inheritdoc cref="IUrlQueryStringStartBuilder.Where" />
    public IUrlQueryStringValueBuilder Where(string key)
    {
        _stringBuilder.Append("?");
        _stringBuilder.Append(key);

        return this;
    }

    /// <inheritdoc cref="IUrlQueryStringValueBuilder.Is" />
    public IUrlQueryStringKeyBuilder Is(string value)
    {
        _stringBuilder.Append("=");
        _stringBuilder.Append(value);

        return this;
    }

    /// <inheritdoc cref="IUrlQueryStringKeyBuilder.And" />
    public IUrlQueryStringValueBuilder And(string key)
    {
        _stringBuilder.Append("&");
        _stringBuilder.Append(key);

        return this;
    }

    /// <summary>
    /// Provides the built URL
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return _stringBuilder.ToString();
    }
}
