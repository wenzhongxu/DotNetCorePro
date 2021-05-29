using Abp.Application.Services.Dto;

namespace Abp.Pdnf.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

