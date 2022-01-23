namespace XpressUrl;

/// <summary>
/// Builds the query string values for a URL
/// </summary>
public interface IUrlQueryStringValueBuilder
{
    /// <summary>
    /// Appends a query string value to the URL
    /// </summary>
    /// <param name="value">The query string value to append to the URL</param>
    /// <returns>The builder for the URL being built</returns>
    IUrlQueryStringKeyBuilder Is(string value);
}
