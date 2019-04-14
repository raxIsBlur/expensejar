using Abp.Authorization;
using expensejar.Authorization.Roles;
using expensejar.Authorization.Users;

namespace expensejar.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
