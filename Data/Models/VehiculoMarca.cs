using System.ComponentModel.DataAnnotations;
namespace Vehiculos_20200091.Data.Models;

public class VehiculoMarca{
    [Key]
    public int MarcaId{get; set;}
    public string? Marca {get; set;}
    public static VehiculoMarca Crear(string marca) 
    =>new VehiculoMarca(){Marca = marca};
}
