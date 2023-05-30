using System.Collections.Generic;
using System.Linq;
using Sp.AvSec.Roles.Dto;
using Sp.AvSec.Users.Dto;

namespace Sp.AvSec.Mvc.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.Name);
        }
    }
}