namespace XpressUrl;

/// <summary>
/// Builds the query string keys for a URL
/// </summary>
public interface IUrlQueryStringKeyBuilder
{
    /// <summary>
    /// Appends a query string key to the URL
    /// </summary>
    /// <param name="key">The query string key to append to the URL</param>
    /// <returns>The builder for the URL being built</returns>
    IUrlQueryStringValueBuilder And(string key);
}
