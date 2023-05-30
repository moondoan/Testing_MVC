using System.Collections.Generic;
using Sp.AvSec.Roles.Dto;
using Sp.AvSec.Users.Dto;

namespace Sp.AvSec.Mvc.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}