namespace POM_GitRepoHomework.Data
{
    public static class SearchFactory
    {
        public static NewSearch StartNewSearch()
        {
            return new NewSearch
            {
                GoogleSearchInput = "Selenium",
            };
        }
    }
}