using Abp.Authorization;
using Sp.AvSec.Authorization.Roles;
using Sp.AvSec.Authorization.Users;

namespace Sp.AvSec.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
