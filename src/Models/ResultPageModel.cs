public class ResultPageModel {
    public string Titel {get; set;}
    public string Beschrijving {get; set;}

    public ResultPageModel(string titel, string beschrijving) {
        Titel = titel;
        Beschrijving = beschrijving;
    }

}