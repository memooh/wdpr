using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Input;

namespace Models.Input
{

    public class RegistreerAlsClient : RegistratieModel
    {
        [Required]
        [Display(Name = "Ben je een ouder?")]
        public string VoogdSelectie { get; set; }

        public SelectList VoogdOpties = new SelectList(
            new List<SelectListItem>
            {
                new SelectListItem { Selected = true, Text = "Ja", Value = "Ja"},
                new SelectListItem { Selected = false, Text = "Nee", Value = "Nee"},
            }, "Value", "Text");

        [Display(Name = "Voogd email")]
        [EmailAddress]
        public string VoogdEmail { get; set; }

        [NotMapped]
        public bool IsVoogd { get { return BerekenIfVoogd(); } }

        public bool BerekenIfVoogd() {
            return VoogdSelectie == "Ja" ? true : false;
        }
    }
}
