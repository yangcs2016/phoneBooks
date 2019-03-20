using System.ComponentModel.DataAnnotations;

namespace Book.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}