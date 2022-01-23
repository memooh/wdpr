using System.Collections.Generic;

public interface IBehandeling {
        public int Id {get; set;}
        public string Naam {get; set;}
        public ICollection<Behandeld> Behandelaren {get; set;}
}