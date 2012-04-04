using System.IO;
using NUnit.Framework;
using Rss;

namespace RSS.NET.TESTS
{
    [TestFixture]
    public class RssReaderFixture
    {
        private RssFeed SUT;

        [SetUp]
        public void Setup()
        {
            SUT = RssFeed.Read(XmlResourceLoader.Load("rss.xml"));
        }

        [Test]
        public void VerifyThatEnclosureIsNotNullWhenItemIsFilledIn()
        {
            Assert.IsNotNull(SUT.Channels[0].Items[0].Enclosure);
            Assert.IsNotNull(SUT.Channels[0].Items[0].Enclosure.Url);
        }

       
    }
}
