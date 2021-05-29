using Abp.Authorization;
using Abp.Pdnf.Authorization.Roles;
using Abp.Pdnf.Authorization.Users;

namespace Abp.Pdnf.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
