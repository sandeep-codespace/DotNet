using System.Collections.Generic;
using System.Text;

namespace DotNetBasics.DesignPatterns.Creational.Prototype
{
    public class UserAccount : IUserPrototype
    {
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public List<string> Permissions { get; } = new();
        public List<string> OnboardingTasks { get; } = new();

        public IUserPrototype Clone()
        {
            var clone = new UserAccount
            {
                Username = Username,
                Role = Role,
                Email = Email,
                IsActive = IsActive
            };

            clone.Permissions.AddRange(Permissions);
            clone.OnboardingTasks.AddRange(OnboardingTasks);

            return clone;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Username: {Username}");
            builder.AppendLine($"Role: {Role}");
            builder.AppendLine($"Email: {Email}");
            builder.AppendLine($"Active: {IsActive}");
            builder.AppendLine("Permissions:");
            Permissions.ForEach(permission => builder.AppendLine($" - {permission}"));
            builder.AppendLine("Onboarding Tasks:");
            OnboardingTasks.ForEach(task => builder.AppendLine($" - {task}"));
            return builder.ToString();
        }
    }
}