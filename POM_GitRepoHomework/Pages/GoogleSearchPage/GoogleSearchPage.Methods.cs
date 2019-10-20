using System.Threading;

namespace POM_GitRepoHomework.Pages
{
    public partial class GoogleSearchPage
    {

        public void Elements(NewSearch search)
        {
            GoogleSearchInput.SendKeys(search.GoogleSearchInput);
            GoogleSearchEngine.Click();
            FirstLink.Click();
        }
        public void Navigate(GoogleSearchPage google_searchPage)
        {
            google_searchPage.Navigate("https://www.google.com/?hl=en");
            Thread.Sleep(5000);
            google_searchPage.GoogleSearchEngine.Click();
            google_searchPage.FirstLink.Click();
        }
    }
}