# XpressUrl

`XpressUrl` allows you to build URLs expressively and fluently, adding multi level domains, paths and query strings.

The solution contains the following packages:
- [XpressUrl](https://www.nuget.org/packages/XpressUrl/) - builds URLs with expressive and fluent syntax.
- [XpressUrl.DependencyInjection](https://www.nuget.org/packages/XpressUrl.DependencyInjection/) - registers `XpressUrl` for dependency injection.
- [XpressUrl.TopLevelDomains](https://www.nuget.org/packages/XpressUrl.TopLevelDomains/) - appends well known top level domains to URLs.

# Getting started

Install the Nuget package `XpressUrl.DependencyInjection` to your project:
```
dotnet add package XpressUrl.DependencyInjection
```

In your application's startup import the `XpressUrl.DependencyInjection` namespace and call `AddXpressUrl()` on your service collection:
```
using XpressUrl.DependencyInjection;
...
services.AddXpressUrl();
```

Import the namespace `XpressUrl` and provide `IUrlGenerator` to the class you want to build a URL in:
```
using XpressUrl;

namespace XpressUrlTest;

public class MyUrlBuilder
{
    private readonly IUrlGenerator _urlGenerator;

    public MyUrlBuilder(IUrlGenerator urlGenerator)
    {
        _urlGenerator = urlGenerator;
    }

    public void BuildAndLogUrl()
    {
        var url = _urlGenerator
            .Https("api")
            .Dot("github")
            .Dot("com")
            .Slash("repos")
            .Slash("JonnyOrman")
            .Slash("XpressUrl")
            .Where("key1").Is("value1")
            .And("key2").Is("value2")
            .ToString();

        Console.WriteLine(url); // outputs the built url "https://api.github.com/repos/JonnyOrman/XpressUrl?key1=value1&key2=value2"
    }
}
```

# XpressUrl.TopLevelDomains

`XpressUrl.TopLevelDomains` can be used to append well known top level domains to your URLs.

Install the Nuget package `XpressUrl.TopLevelDomains` to your project:
```
dotnet add package XpressUrl.TopLevelDomains
```

Import the namespace `XpressUrl.TopLevelDomains` to use the various extension methods in the package to append top level domains to your URLs. The following appends `.com` to the URL by using the `DotCom()` extension method:
```
using XpressUrl.TopLevelDomains;
...
var url = _urlGenerator
            .Https("github")
            .DotCom()
            .ToString();
```
