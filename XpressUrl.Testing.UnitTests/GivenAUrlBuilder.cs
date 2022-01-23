using Xunit;

namespace XpressUrl.Testing.UnitTests;

public class GivenAUrlBuilder
{
    public class WhenAUrlIsBuilt
    {
        [Fact]
        public void ThenTheUrlIsBuilt()
        {
            var expectedUrl = "http://myurl.com/path?key=value";

            var actualUrl = new UrlBuilder("http://myurl")
                .Dot("com")
                .Slash("path")
                .Where("key")
                .Is("value")
                .ToString();

            Assert.Equal(expectedUrl, actualUrl);
        }
    }
}
