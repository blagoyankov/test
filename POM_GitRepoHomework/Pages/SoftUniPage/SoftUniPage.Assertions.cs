using NUnit.Framework;
using OpenQA.Selenium;

namespace POM_GitRepoHomework.Pages
{
    public partial class SoftUniPage
    {
        public IWebElement Header => Driver.FindElement(By.XPath("/html/body/div[2]/header/h1"));
        public void AssertHeader(string expected)
        {
            Assert.AreEqual(expected, Header.Text);
        }
    }
}