using Abp.Application.Services.Dto;

namespace Sp.AvSec.CardTemplates.Dto
{
    public class CardTemplateDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public bool IsActive { get; set; }
    }
}
