using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace POM_GitRepoHomework.Pages
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver)
            : base(driver)
        {
        }
        public IWebElement GoogleSearchInput => Driver.FindElement(By.ClassName("a4bIc"));
        public IWebElement GoogleSearchEngine => Driver.FindElement(By.ClassName("sbtc"));
        public IWebElement FirstLink => Driver.FindElement(By.ClassName("LC20lb"));
    }
}