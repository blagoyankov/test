using NUnit.Framework;
using OpenQA.Selenium;

namespace POM_GitRepoHomework.Pages
{
    public partial class GoogleSearchPage
    {
        public IWebElement Header => Driver.FindElement(By.XPath("/html/body/div[2]/header/h1"));
        public void PageHeader(string expected)
        {
            Assert.AreEqual(expected, Header.Text);
        }
    }
}