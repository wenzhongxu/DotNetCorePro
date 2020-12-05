using System.ComponentModel.DataAnnotations;

namespace VODDY.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}