namespace DotNetBasics.DesignPatterns.Creational.Prototype
{
    public static class UserOnboardingDirector
    {
        public static UserAccount OnboardStandardUser(string username, string email)
        {
            var prototype = UserPrototypeFactory.CreateStandardUserTemplate();
            return BuildUserFromPrototype(prototype, username, email);
        }

        public static UserAccount OnboardManagerUser(string username, string email)
        {
            var prototype = UserPrototypeFactory.CreateManagerUserTemplate();
            return BuildUserFromPrototype(prototype, username, email);
        }

        public static UserAccount OnboardAdminUser(string username, string email)
        {
            var prototype = UserPrototypeFactory.CreateAdminUserTemplate();
            return BuildUserFromPrototype(prototype, username, email);
        }

        private static UserAccount BuildUserFromPrototype(UserAccount prototype, string username, string email)
        {
            var user = (UserAccount)prototype.Clone();
            user.Username = username;
            user.Email = email;
            user.OnboardingTasks.Add($"Welcome email sent to {email}");
            return user;
        }
    }
}