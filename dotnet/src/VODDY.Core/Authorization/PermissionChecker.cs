using Abp.Authorization;
using VODDY.Authorization.Roles;
using VODDY.Authorization.Users;

namespace VODDY.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
