using System.ComponentModel.DataAnnotations;

namespace Hiraya.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}