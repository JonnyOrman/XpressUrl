using Xunit;

namespace XpressUrl.Testing.IntegrationTests;

public class GivenAUrlGenerator
{
    private readonly UrlGenerator _urlGenerator;

    public GivenAUrlGenerator()
    {
        _urlGenerator = new UrlGenerator();
    }

    public class WhenAUrlIsGenerated : GivenAUrlGenerator
    {
        [Fact]
        public void ItShouldBuildTheUrl()
        {
            var expectedUrl = "https://api.github.com/repos/JonnyOrman/XpressUrl";

            var actualUrl = _urlGenerator
                .Https("api")
                .Dot("github")
                .Dot("com")
                .Slash("repos")
                .Slash("JonnyOrman")
                .Slash("XpressUrl")
                .ToString();

            Assert.Equal(expectedUrl, actualUrl);
        }

        public class AndAQueryStringIsAdded : WhenAUrlIsGenerated
        {
            [Fact]
            public void ItShouldBuildTheUrlWithTheQueryString()
            {
                var expectedUrl = "https://api.github.com/repos/JonnyOrman/XpressUrl?key1=value1&key2=value2";

                var actualUrl = _urlGenerator
                    .Https("api")
                    .Dot("github")
                    .Dot("com")
                    .Slash("repos")
                    .Slash("JonnyOrman")
                    .Slash("XpressUrl")                            
                    .Where("key1").Is("value1")
                    .And("key2").Is("value2")
                    .ToString();

                Assert.Equal(expectedUrl, actualUrl);
            }
        }
    }
}