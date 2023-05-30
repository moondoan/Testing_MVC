using Abp.Application.Navigation;

namespace Sp.AvSec.Mvc.Models.Layout
{
    public class SideBarNavViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}