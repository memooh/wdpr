using System;
using System.Collections.Generic;
using Models;

public interface IMelding {
    public int Id {get; set;}
    public string Beschrijving {get; set;}
    public DateTime Datum {get; set;}
    public Bericht Bericht {get; set;}
}