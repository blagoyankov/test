namespace POM_GitRepoHomework.Pages
{
    public partial class SoftUniPage
    {

        public void Elements(SoftUniPage user)
        {
            allCourses.Click();
            course.Click();
        }
        public void Navigate(SoftUniPage softuniPage)
        {
            softuniPage.Navigate("https://softuni.bg/");

            softuniPage.allCourses.Click();
            softuniPage.course.Click();
        }
    }
}