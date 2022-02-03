
using System;
using System.ComponentModel.DataAnnotations;

public class AanmeldModel {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Voornaam { get; set; }

        [Required]
        public string Achternaam { get; set; }

        [Required]
        public string Adres {get; set;}
        
        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Een postcode kan maar 6 karakters zijn")]
        public string Postcode {get; set;}
        
        [Required]
        public string Woonplaats {get; set;}

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Geboortedatum {get; set;}
}