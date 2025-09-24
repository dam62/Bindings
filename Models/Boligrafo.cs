using System;
using System.Runtime.InteropServices.JavaScript;

namespace Bindings.Models;

public class Boligrafo
{
    public string Codigo { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    
    public DateTime Fecha { get; set; } = DateTime.Today;

    public override string ToString()
    {
        return "Codigo: "+Codigo+", Color: "+Color;
    }
}