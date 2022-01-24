namespace XpressUrl.TopLevelDomains;

/// <summary>
/// Extension methods for appending top level domains to a URL builder
/// </summary>
public static class TopLevelDomainExtensions
{
    /// <summary>
    /// Appends the .com top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotCom(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("com");
    }

    /// <summary>
    /// Appends the .ru top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotRu(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("ru");
    }

    /// <summary>
    /// Appends the .org top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotOrg(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("org");
    }

    /// <summary>
    /// Appends the .net top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotNet(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("net");
    }

    /// <summary>
    /// Appends the .in top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotIn(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("in");
    }

    /// <summary>
    /// Appends the .ir top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotIr(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("ir");
    }

    /// <summary>
    /// Appends the .au top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotAu(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("au");
    }

    /// <summary>
    /// Appends the .uk top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotUk(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("uk");
    }

    /// <summary>
    /// Appends the .ua top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotUa(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("ua");
    }

    /// <summary>
    /// Appends the .ca top level domain to the URL
    /// </summary>
    /// <returns>The builder for the URL being built</returns>
    public static IUrlPathBuilder DotCa(this IUrlDomainBuilder urlDomainBuilder)
    {
        return urlDomainBuilder.AppendTopLevelDomain("ca");
    }

    private static IUrlPathBuilder AppendTopLevelDomain(this IUrlDomainBuilder urlDomainBuilder, string topLevelDomain)
    {
        urlDomainBuilder.Dot(topLevelDomain);
        return urlDomainBuilder;
    }
}
