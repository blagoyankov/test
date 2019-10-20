using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using POM_GitRepoHomework.Pages;
using System;

namespace POM_GitRepoHomework.Tests
{
    [TestFixture]
    public class PageObjectModel
    {
        private RemoteWebDriver _driver;
        private RegistrationUser _user;
        private LoginPage _loginPage;
        private RegistrationPage _registrationPage;
        private SoftUniPage _softuniPage;
        private NewSearch _search;
        private GoogleSearchPage _google_searchPage;

        [SetUp]
        public void CalssInit()
        {
            ChromeOptions options = new ChromeOptions();
            options.PlatformName = "windows";
            options.BrowserVersion = "77";

            _driver = new RemoteWebDriver(new Uri("http://192.168.1.11:47909/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _driver.Manage().Window.Maximize();
            _loginPage = new LoginPage(_driver);
            _registrationPage = new RegistrationPage(_driver);
            _user = UserFactory.CreateNewUser();
            _softuniPage = new SoftUniPage(_driver);
            _google_searchPage = new GoogleSearchPage(_driver);
        }

        [Test]
        public void Registration_SubmitEmail()
        {
            _registrationPage.Navigate(_loginPage);

            _registrationPage.AssertMessage("some_email3978@gmail.com");
        }

        [Test]
        public void Registration_NoPhoneNumber()
        {
            _user.Phone = "";

            _registrationPage.Navigate(_loginPage);

            _registrationPage.FillForm(_user);

            _registrationPage.RegisterButton.Click();

            _registrationPage.AssertErrorMessage1("You must register at least one phone number.");
        }

        [Test]
        public void Registration_NoLastName()
        {
            _user.LastName = "";

            _registrationPage.Navigate(_loginPage);

            _registrationPage.FillForm(_user);

            _registrationPage.RegisterButton.Click();

            _registrationPage.AssertErrorMessage1("lastname is required.");
        }

        [Test]
        public void Registration_NoCity()
        {
            _user.City = "";

            _registrationPage.Navigate(_loginPage);

            _registrationPage.FillForm(_user);

            _registrationPage.RegisterButton.Click();

            _registrationPage.AssertErrorMessage2("city is required.");
        }

        [Test]
        public void Registration_WrongPostcode()
        {
            _user.Postcode = "1212";

            _registrationPage.Navigate(_loginPage);

            _registrationPage.FillForm(_user);

            _registrationPage.RegisterButton.Click();

            _registrationPage.AssertErrorMessage2("The Zip/Postal code you've entered is invalid. It must follow this format: 00000");
        }

        [Test]
        public void Registration_NoPassword()
        {
            _user.Password = "";

            _registrationPage.Navigate(_loginPage);

            _registrationPage.FillForm(_user);

            _registrationPage.RegisterButton.Click();

            _registrationPage.AssertErrorMessage1("passwd is required.");
        }

        [Test]
        public void QaAutomation()
        {
            _softuniPage.Navigate(_softuniPage);

            _softuniPage.AssertHeader("QA Automation - септември 2019");
        }

        [Test]
        public void GoogleSearch()
        {
            _google_searchPage.Navigate(_google_searchPage);

            _google_searchPage.PageHeader("Selenium - Web Browser Automation");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
