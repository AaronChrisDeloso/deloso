using System.ComponentModel.DataAnnotations;

namespace deloso.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}