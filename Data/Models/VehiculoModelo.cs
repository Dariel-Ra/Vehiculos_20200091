using System.ComponentModel.DataAnnotations;
namespace Vehiculos_20200091.Data.Models;

public class VehiculoModelo{
    [Key]
    public int ModeloId{get; set;}
    public string? Modelo {get; set;}
    public static VehiculoModelo Crear(string modelo)
    =>new VehiculoModelo(){Modelo = modelo};
}