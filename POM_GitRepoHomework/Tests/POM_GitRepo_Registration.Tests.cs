using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using POM_GitRepoHomework.Pages;
using System;
using System.IO;
using System.Reflection;

namespace POM_GitRepoHomework
{
    [TestFixture]
    public class PageObjectModel
    {
        private ChromeDriver _driver;
        private RegistrationUser _user;
        private LoginPage _loginPage;
        private RegistrationPage _registrationPage;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _loginPage = new LoginPage(_driver);
            _registrationPage = new RegistrationPage(_driver);
            _user = UserFactory.CreateNewUser();
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

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
