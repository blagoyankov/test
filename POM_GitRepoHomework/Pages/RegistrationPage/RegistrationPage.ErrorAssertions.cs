using NUnit.Framework;
using OpenQA.Selenium;

namespace POM_GitRepoHomework.Pages
{
    public partial class RegistrationPage
    {
        public IWebElement ErrorMessage1 => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li"));
        public void AssertErrorMessage1(string expected)
        {
            Assert.AreEqual(expected, ErrorMessage1.Text);
        }
        public IWebElement ErrorMessage2 => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li[2]"));
        public void AssertErrorMessage2(string expected)
        {
            Assert.AreEqual(expected, ErrorMessage2.Text);
        }
    }
}