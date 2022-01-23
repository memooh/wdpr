using Models;

public interface IBehandeld {
    public int Id { get; set; }
    public Behandeling Behandeling {get; set;}
    public Gebruiker Behandelaar {get; set;}
}