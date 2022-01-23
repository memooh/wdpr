using System;

namespace Models {

    public class AanmeldingModel {

        public string Gebruikersnaam {get;set;}
        public string Voornaam {get;set;}
        public string Achternaam {get;set;}
        public DateTime GeboorteDatum {get;set;}
        public DateTime Datum {get;set;}
        public string VoogdEmail {get;set;}
        public string BehandelaarEmail {get;set;}
        public bool? VoogdToestemming {get;set;}
        


    }
}