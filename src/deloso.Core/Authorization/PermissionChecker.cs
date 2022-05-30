using Abp.Authorization;
using deloso.Authorization.Roles;
using deloso.Authorization.Users;

namespace deloso.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
