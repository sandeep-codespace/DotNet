# Prototype Pattern Example

## User Onboarding Prototype

This example demonstrates the Prototype pattern by cloning user templates for onboarding.

- A `StandardUser` template is defined once.
- `ManagerUser` and `AdminUser` clones are derived from the standard template and then customized.
- Each prototype includes permissions, onboarding tasks, and role-specific defaults.

### Why Prototype?

Use Prototype when you want to create new objects by copying an existing object instead of building from scratch.

Example: create new onboarding accounts for standard, manager, and admin users with shared defaults and customized role settings.
