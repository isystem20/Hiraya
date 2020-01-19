using Abp.Authorization;
using Hiraya.Authorization.Roles;
using Hiraya.Authorization.Users;

namespace Hiraya.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
