using System.ComponentModel.DataAnnotations;

namespace expensejar.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}