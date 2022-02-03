using System.ComponentModel.DataAnnotations;

namespace Models.Input
{
    public class RegistratieModel : AanmeldModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "De {0} moet minimaal tussen de {2} en maximaal {1} tekens lang zijn.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        public string Wachtwoord { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bevestig wachtwoord")]
        [Compare("Wachtwoord", ErrorMessage = "De wachtwoord en bevestiging zijn niet gelijk")]
        public string BevestigWachtwoord { get; set; }

        public bool IsActief {get; set;}
    }
}