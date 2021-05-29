using System.ComponentModel.DataAnnotations;

namespace Abp.Pdnf.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}