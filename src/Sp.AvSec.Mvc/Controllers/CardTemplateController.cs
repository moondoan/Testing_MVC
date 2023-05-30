using Abp.Web.Mvc.Authorization;
using Sp.AvSec.Authorization;
using Sp.AvSec.CardTemplates;
using Sp.AvSec.Mains.CardTemplates.Dto;
using Sp.AvSec.Mvc.Models.CardTemplates;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sp.AvSec.Mvc.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_CardTemplates)]
    public class CardTemplateController : Controller
    {
        private readonly ICardTemplateAppService _cardTemplateAppService;

        // GET: CardTemplate
        public async Task<ActionResult> IndexAsync()
        {
            var cardTemplates = await _cardTemplateAppService.GetPagedAsync(new GetPagedCardTemplateInput { Filter = string.Empty });
            var model = new CardTemplateListViewModel
            {
                CardTemplates = cardTemplates
            };

            return View(model);
        }
    }
}