using System.ComponentModel.DataAnnotations;

namespace Models.Input
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Wachtwoord { get; set; }

        [Display(Name = "Onthou me")]
        public bool RememberMe { get; set; }
    }
}