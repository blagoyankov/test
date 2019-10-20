using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace POM_GitRepoHomework.Pages
{
    public partial class RegistrationPage
    {

        public void FillForm(RegistrationUser user)
        {
            Gender[0].Click();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Day.SelectByValue(user.Day);
            Month.SelectByValue(user.Month);
            Year.SelectByValue(user.Year);
            RealFirstName.SendKeys(user.RealFirstName);
            RealLastName.SendKeys(user.RealLastName);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            Postcode.SendKeys(user.Postcode);
            Phone.SendKeys(user.Phone);
            Alias.SendKeys(user.Alias);
            RegisterButton.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate("http://automationpractice.com/index.php?controller=my-account");

            loginPage.Email.SendKeys("some_email3978@gmail.com");
            loginPage.Submit.Click();
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementExists((By.Id("uniform-id_gender1"))));
        }
    }
}