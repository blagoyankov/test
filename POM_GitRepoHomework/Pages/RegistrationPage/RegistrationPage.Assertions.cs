using NUnit.Framework;
using OpenQA.Selenium;

namespace POM_GitRepoHomework.Pages
{
    public partial class RegistrationPage
    {
        string Email => Driver.FindElement(By.Id("email")).GetAttribute("value");
        public void AssertMessage(string expected)
        {
            Assert.AreEqual(expected, Email);
        }
    }
}