namespace XpressUrl;

/// <summary>
/// Builds the start of the query string for a URL
/// </summary>
public interface IUrlQueryStringStartBuilder
{
    /// <summary>
    /// Appends the start of the query string and the initial key to the URL
    /// </summary>
    /// <param name="key">The initial query string key to append to the URL</param>
    /// <returns>The builder for the URL being built</returns>
    IUrlQueryStringValueBuilder Where(string key);
}
