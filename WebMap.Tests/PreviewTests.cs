using Xunit;

namespace WebMap.Tests
{
    // The card Discord shows for the map's address (Preview): this server's name, once.
    public class PreviewTests
    {
        private const string Page = "<html><head>\n<title>T</title>\n<meta name=\"description\" content=\"Old\">\n<meta property=\"og:title\" content=\"Valheim WebMap\">\n</head><body></body></html>";

        [Fact]
        public void APageCarriesThisServersCardAndNotTheFixedOne()
        {
            WebMapConfig.PREVIEW_DESCRIPTION = "";
            string html = Preview.Inject(Page, "Les Vikings & co", "https://map.example.com", null);
            Assert.DoesNotContain("Valheim WebMap", html);
            Assert.DoesNotContain("content=\"Old\"", html);
            Assert.Contains("<meta property=\"og:title\" content=\"Les Vikings &amp; co\">", html);
            Assert.Contains("<meta property=\"og:url\" content=\"https://map.example.com/\">", html);
            Assert.Contains("twitter:card\" content=\"summary\"", html);
            Assert.Single(System.Text.RegularExpressions.Regex.Matches(html, "og:description"));
            Assert.Contains("<title>T</title>", html);
        }

        [Fact]
        public void APictureMakesItALargeCard()
        {
            WebMapConfig.PREVIEW_DESCRIPTION = "Notre monde";
            string html = Preview.Inject(Page, "S", null, "https://x/p.png");
            Assert.Contains("og:image\" content=\"https://x/p.png\"", html);
            Assert.Contains("summary_large_image", html);
            Assert.Contains("content=\"Notre monde\"", html);
            Assert.DoesNotContain("og:url", html);
            WebMapConfig.PREVIEW_DESCRIPTION = "";
        }

        [Theory]
        [InlineData("a.PNG", "image/png")]
        [InlineData("a.jpeg", "image/jpeg")]
        [InlineData("a.svg", null)]
        public void OnlyPicturesAppsShowAreServed(string file, string type) => Assert.Equal(type, Preview.ContentType(file));
    }
}
