using Xunit;

namespace XpressUrl.Testing.UnitTests;

public class GivenAUrlGenerator
{
    private readonly UrlGenerator _urlGenerator;

    public GivenAUrlGenerator()
    {
        _urlGenerator = new UrlGenerator();
    }

    public class WhenAWwwUrlIsGenerated : GivenAUrlGenerator
    {
        [Fact]
        public void ThenTheUrlBeginsWithWww()
        {
            var expectedStart = "www.";

            var actualStart = _urlGenerator.WwwDot(string.Empty).ToString();

            Assert.StartsWith(expectedStart, actualStart);
        }
    }

    public class WhenAHttpUrlIsGenerated : GivenAUrlGenerator
    {
        [Fact]
        public void ThenTheUrlBeginsWithHttp()
        {
            var expectedStart = "http://";

            var actualStart = _urlGenerator.Http(string.Empty).ToString();

            Assert.StartsWith(expectedStart, actualStart);
        }
    }

    public class WhenAHttpsUrlIsGenerated : GivenAUrlGenerator
    {
        [Fact]
        public void ThenTheUrlBeginsWithHttps()
        {
            var expectedStart = "https://";

            var actualStart = _urlGenerator.Https(string.Empty).ToString();

            Assert.StartsWith(expectedStart, actualStart);
        }
    }
}
