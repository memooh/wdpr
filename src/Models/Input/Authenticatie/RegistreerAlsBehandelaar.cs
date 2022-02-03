using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace Models.Input
{
    public class RegistreerAlsBehandelaar : RegistratieModel
    {
        [Required]
        [Display(Name = "Welke behandeling(en) behandel je?")]
        public int[] GeselecteerdeBehandelingen { get; set; }
        public SelectList Behandelingen { get; set; }
        public RegistreerAlsBehandelaar() { }

        [Required(ErrorMessage = "Vergeet niet wat over jezelf te vertellen!")]
        [Display(Name = "Vertel wat over jezelf")]
        public string Beschrijving { get; set; }

        [Display(Name = "Afbeelding")]
        [Required]
        public IFormFile Afbeelding { get; set; }

        public RegistreerAlsBehandelaar(IEnumerable<Behandeling> behandelingen)
        {
            Behandelingen = new SelectList(behandelingen, "Id", "Naam");
        }
    }
}