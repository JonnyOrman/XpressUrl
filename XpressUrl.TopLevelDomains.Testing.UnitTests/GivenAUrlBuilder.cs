using Xunit;

namespace XpressUrl.TopLevelDomains.Testing.UnitTests;

public class GivenAUrlBuilder
{
    private readonly UrlBuilder _urlBuilder;

    public GivenAUrlBuilder()
    {
        _urlBuilder = new UrlBuilder("https://mydomain");
    }

    public class WhenDotComIsAppended : GivenAUrlBuilder
    {
        public WhenDotComIsAppended()
        {
            _urlBuilder.DotCom();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotCom()
        {
            Assert.EndsWith(".com", _urlBuilder.ToString());
        }
    }

    public class WhenDotRuIsAppended : GivenAUrlBuilder
    {
        public WhenDotRuIsAppended()
        {
            _urlBuilder.DotRu();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotRu()
        {
            Assert.EndsWith(".ru", _urlBuilder.ToString());
        }
    }

    public class WhenDotOrgIsAppended : GivenAUrlBuilder
    {
        public WhenDotOrgIsAppended()
        {
            _urlBuilder.DotOrg();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotOrg()
        {
            Assert.EndsWith(".org", _urlBuilder.ToString());
        }
    }

    public class WhenDotNetIsAppended : GivenAUrlBuilder
    {
        public WhenDotNetIsAppended()
        {
            _urlBuilder.DotNet();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotNet()
        {
            Assert.EndsWith(".net", _urlBuilder.ToString());
        }
    }

    public class WhenDotInIsAppended : GivenAUrlBuilder
    {
        public WhenDotInIsAppended()
        {
            _urlBuilder.DotIn();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotIn()
        {
            Assert.EndsWith(".in", _urlBuilder.ToString());
        }
    }

    public class WhenDotIrIsAppended : GivenAUrlBuilder
    {
        public WhenDotIrIsAppended()
        {
            _urlBuilder.DotIr();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotIr()
        {
            Assert.EndsWith(".ir", _urlBuilder.ToString());
        }
    }

    public class WhenDotAuIsAppended : GivenAUrlBuilder
    {
        public WhenDotAuIsAppended()
        {
            _urlBuilder.DotAu();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotAu()
        {
            Assert.EndsWith(".au", _urlBuilder.ToString());
        }
    }

    public class WhenDotUkIsAppended : GivenAUrlBuilder
    {
        public WhenDotUkIsAppended()
        {
            _urlBuilder.DotUk();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotUk()
        {
            Assert.EndsWith(".uk", _urlBuilder.ToString());
        }
    }

    public class WhenDotUaIsAppended : GivenAUrlBuilder
    {
        public WhenDotUaIsAppended()
        {
            _urlBuilder.DotUa();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotUa()
        {
            Assert.EndsWith(".ua", _urlBuilder.ToString());
        }
    }

    public class WhenDotCaIsAppended : GivenAUrlBuilder
    {
        public WhenDotCaIsAppended()
        {
            _urlBuilder.DotCa();
        }

        [Fact]
        public void ThenTheTopLevelDomainIsDotCa()
        {
            Assert.EndsWith(".ca", _urlBuilder.ToString());
        }
    }
}