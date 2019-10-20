using OpenQA.Selenium;

namespace POM_GitRepoHomework.Pages
{
    public partial class SoftUniPage : BasePage
    {
        public SoftUniPage(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement allCourses => Driver.FindElement(By.XPath("//*[@id='header-nav']/div[1]/ul/li[2]/a/span"));
        public IWebElement course => Driver.FindElement(By.XPath("//*[@id='header-nav']/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a"));
    }
}