namespace XpressUrl;

/// <summary>
/// Builds the path for a URL
/// </summary>
public interface IUrlPathBuilder : IUrlQueryStringStartBuilder
{
    /// <summary>
    /// Appends a path section to the URL
    /// </summary>
    /// <param name="pathSection">The path section to append to the URL</param>
    /// <returns>The builder for the URL being built</returns>
    IUrlPathBuilder Slash(string pathSection);
}
