using System.ComponentModel.DataAnnotations;
namespace Vehiculos_20200091.Data.Models;

public class VehiculoColor{
    [Key]
    public int ColorId {get; set;}
    public string? Color {get; set;}
    public static VehiculoColor Crear(string color) 
    =>new VehiculoColor(){Color = color};
}
