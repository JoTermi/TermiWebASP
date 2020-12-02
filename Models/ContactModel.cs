using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TermiConsult.Models
{
    public class ContactModel
    {
        [DisplayName("Vorname")]
        [Required(ErrorMessage = "Voname ist erforderlich.")]
        public string Vorname { get; set; } = "";


        [DisplayName("Nachname")]
        [Required(ErrorMessage = "Nachname ist erforderlich.")]
        public string Nachname { get; set; } = "";

        [DisplayName("Weiblich")]
        public bool IsFemale { get; set; } = false;

        [DisplayName("Männlich")]
        public bool IsMale { get; set; } = false;


        [DisplayName("Betreff")]
        [Required(ErrorMessage = "Betreff ist erforderlich.")]
        public string Betreff { get; set; } = "";

        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "Email ist erforderlich.")]
        public string FromEmail { get; set; } = "";

        [DisplayName("Nachricht")]
        [Required(ErrorMessage = "Bitte, geben Sie eine Nachricht ein.")]
        public string Message { get; set; } = "";

        [Required(ErrorMessage = "Bitte, prüfen Sie Ihre Eingabe")]
        public int PruefWert { get; set; } = 0;
    }
}
