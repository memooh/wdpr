using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

public class AanmeldenAlsClient: AanmeldModel {

    public List<Gebruiker> Clienten = new List<Gebruiker>();

    [HiddenInput(DisplayValue = false)]
    public int BehandelingId {get; set;}

    [HiddenInput(DisplayValue = false)]
    public string BehandelaarId {get; set;}

    public string? VoogdEmail {get; set;}

    public AanmeldenAlsClient() {}

    public bool HasApplied {get; set;}
    public AanmeldenAlsClient(int behandelingId, List<Gebruiker>? clienten, bool hasApplied) {
        Clienten = clienten;
        BehandelingId = behandelingId;
        HasApplied = hasApplied;
    }
}