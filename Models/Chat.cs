namespace Models {
    public class Chat {
        public int Id {get; set;}
        public string Naam {get; set;}
        public Gebruiker Behandelaar {get; set;}
    }
}