using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace POM_GitRepoHomework.Pages
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public new string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";
        public IList<IWebElement> Gender => Wait.Until(d => d.FindElements(By.Id("uniform-id_gender1")));
        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));
        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));
        public IWebElement Password => Driver.FindElement(By.Id("passwd"));
        public SelectElement Day
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("days"));
                return new SelectElement(reminder);
            }
        }
        public SelectElement Month
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("months"));
                return new SelectElement(reminder);
            }
        }
        public SelectElement Year
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("years"));
                return new SelectElement(reminder);
            }
        }
        public IWebElement RealFirstName => Driver.FindElement(By.Id("firstname"));
        public IWebElement RealLastName => Driver.FindElement(By.Id("lastname"));
        public IWebElement Address => Driver.FindElement(By.Id("address1"));
        public IWebElement City => Driver.FindElement(By.Id("city"));
        public SelectElement State
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(reminder);
            }
        }
        public IWebElement Postcode => Driver.FindElement(By.Id("postcode"));
        public IWebElement Phone => Driver.FindElement(By.Id("phone_mobile"));
        public IWebElement Alias => Driver.FindElement(By.Id("alias"));
        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));
    }
}