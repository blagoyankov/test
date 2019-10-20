namespace POM_GitRepoHomework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateNewUser()
        {
            return new RegistrationUser
            {
                Email = "some_email3978@gmail.com",
                Gender = "Male",
                FirstName = "Joro",
                LastName = "Ivanov",
                Password = "jh43dcs234",
                Day = "12",
                Month = "8",
                Year = "1987",
                RealFirstName = "Joro",
                RealLastName = "Ivanov",
                Address = "Center, Some Blvd. 108, 3rd floor",
                City = "Utah",
                State = "Utah",
                Postcode = "12907",
                Phone = "5347838593",
                Alias = "Home address",
            };
        }
    }
}