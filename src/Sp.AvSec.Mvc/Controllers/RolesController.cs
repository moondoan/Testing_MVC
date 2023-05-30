using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using Sp.AvSec.Authorization;
using Sp.AvSec.Roles;
using Sp.AvSec.Mvc.Models.Roles;
using Sp.AvSec.Roles.Dto;
using Sp.AvSec.Authorization.Roles;
using System.Web.Http.Results;

namespace Sp.AvSec.Mvc.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class RolesController : AvSecControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }


        public async Task<ActionResult> Index()
        {
            var roles = (await _roleAppService.GetAllAsync(new PagedAndSortedResultRequestDto())).Items;
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new RoleListViewModel
            {
                Roles = roles,
                Permissions = permissions
            };

            return View(model);
        }

        public async Task<ActionResult> EditRoleModal(int roleId)
        {
            var role = await _roleAppService.GetAsync(new EntityDto(roleId));
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new EditRoleModalViewModel
            {
                Role = role,
                Permissions = permissions
            };
            return View("_EditRoleModal", model);
        }

        public async Task<ActionResult> Update(RoleDto input)
        {
            if (ModelState.IsValid)
            {
                await _roleAppService.UpdateAsync(input);
                RedirectToAction("Index");
            }
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new EditRoleModalViewModel
            {
                Role = input,
                Permissions = permissions
            };
            return View("_EditRoleModal", model);
        }
    }
}