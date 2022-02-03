using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Models.Input;

public class FileHandler
{

    public IWebHostEnvironment _webHostEnvironment;
    public FileHandler(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }
    public string UploadFile(RegistreerAlsBehandelaar model)
    {
        string FileName = null;
        if (model.Afbeelding != null)
        {
            string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            FileName = System.Guid.NewGuid().ToString() + "-" + model.Afbeelding.FileName;
            string filePath = Path.Combine(uploadDir, FileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                model.Afbeelding.CopyTo(fileStream);
            }
        }

        return FileName;
    }
}