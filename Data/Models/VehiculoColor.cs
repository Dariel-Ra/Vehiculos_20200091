using System.ComponentModel.DataAnnotations;
namespace Vehiculos_20200091.Data.Models;

public class VehiculoColor{
    [Key]
    public int ColorId {get; set;}
    public string? Color {get; set;}
    public string? HexColor {get; set;}
    public static VehiculoColor Crear(string color, string hexColor) 
    =>new VehiculoColor(){Color = color, HexColor = hexColor};
}
