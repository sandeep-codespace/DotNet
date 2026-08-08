namespace DotNetBasics.DesignPatterns.Creational.Prototype
{
    public static class UserPrototypeFactory
    {
        public static UserAccount CreateStandardUserTemplate()
        {
            var user = new UserAccount
            {
                Role = "Standard",
                Email = "new.user@example.com",
                IsActive = true
            };

            user.Permissions.Add("Dashboard.View");
            user.Permissions.Add("Profile.Edit");

            user.OnboardingTasks.Add("Complete profile setup");
            user.OnboardingTasks.Add("Review company policies");
            user.OnboardingTasks.Add("Set up multi-factor authentication");

            return user;
        }

        public static UserAccount CreateManagerUserTemplate()
        {
            var manager = (UserAccount)CreateStandardUserTemplate().Clone();
            manager.Role = "Manager";
            manager.Permissions.Add("Team.View");
            manager.Permissions.Add("Team.ApproveRequests");
            manager.OnboardingTasks.Add("Schedule first team meeting");
            return manager;
        }

        public static UserAccount CreateAdminUserTemplate()
        {
            var admin = (UserAccount)CreateStandardUserTemplate().Clone();
            admin.Role = "Admin";
            admin.Permissions.Add("Users.Manage");
            admin.Permissions.Add("Settings.Configure");
            admin.OnboardingTasks.Add("Review security configuration");
            admin.OnboardingTasks.Add("Set up admin reporting");
            return admin;
        }
    }
}