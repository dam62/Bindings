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

    [ObservableProperty] private bool avanzadas = false;
    
    [ObservableProperty] private List<Boligrafo> boligrafos = new();
    
    public string Greeting { set; get; } = "FORMULARIO";
    public string Saludo { set; get; } = "Saludo para la clase";
    
    [ObservableProperty]private Boligrafo boli = new();
    
    
    
    public List<string> ListaColores { set; get; }

    public MainWindowViewModel()
    {
        CargarCombo();
        CargarBolis();
    }

    private void CargarBolis()
    {
        Boligrafo boli = new Boligrafo();
        boli.Codigo = "3214341";
        boli.Color = "Azul";
        Boligrafos.Add(boli);
        
        Boligrafo boli2 = new Boligrafo();
        boli2.Codigo = "234er";
        boli2.Color = "Verde";
        Boligrafos.Add(boli2);
        
        Boligrafo boli3 = new Boligrafo();
        boli3.Codigo = "235632";
        boli3.Color = "Naranja";
        Boligrafos.Add(boli3);
    }

    [RelayCommand]
    public void MostrarOpcionesAvanzadas()
    {
        if (Avanzadas)
        {
            Avanzadas = false;
        }
        else
        {
            Avanzadas = true;
        }
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
            Console.WriteLine(Boli.Codigo+" "+Boli.Color);
            Mensaje = String.Empty;
            Boligrafos.Add(Boli);
            Boli = new Boligrafo();
        }
    }
}