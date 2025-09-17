using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bindings.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bindings.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    // Tenemos que poner el decorador
    // La variable u objeto tiene que ser privado
    // Tiene que empezar por minuscula
    // No tiene que tener get y set
    [ObservableProperty]
    private string mensaje = string.Empty;
    
    public string Greeting { set; get; } = "hola Pedro";
    public string Saludo { set; get; } = "Saludo para la clase";
    
    public Boligrafo Boli { get; set; } = new();
    
    
    
    public List<string> ListaColores { set; get; }

    public MainWindowViewModel()
    {
        CargarCombo();
    }

    private void CargarCombo()
    {
        ListaColores = new()
        {
            "Rojo", "Naranja", "Verde", "Azul"
        };
        Boli.Color = ListaColores[0];
    }

    [RelayCommand]
    public void MostrarBoli(object parameter)
    {
        if (parameter is false)
        {
            Mensaje = "Debes marcar el check";
            Console.WriteLine("Debes marcar el check");
            return;
        }
        
        if (string.IsNullOrWhiteSpace(Boli.Codigo))
        {
            Mensaje = "Debes indicar un codigo";
            Console.WriteLine("Debes indicar un codigo");
        }
        else
        {
            Mensaje = String.Empty;
            Console.WriteLine(Boli.Codigo+" "+Boli.Color);
        }
    }
}