using System.Collections.Generic;
using Sp.AvSec.Roles.Dto;

namespace Sp.AvSec.Mvc.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}