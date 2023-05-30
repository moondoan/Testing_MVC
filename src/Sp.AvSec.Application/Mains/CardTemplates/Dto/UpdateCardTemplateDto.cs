using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Sp.AvSec.Mains;
using System.ComponentModel.DataAnnotations;

namespace Sp.AvSec.CardTemplates.Dto
{
    public class UpdateCardTemplateDto : EntityDto<int>
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(256)]
        public string FileName { get; set; }

        public string FilePath { get; set; }

        public bool IsActive { get; set; }
    }
}
