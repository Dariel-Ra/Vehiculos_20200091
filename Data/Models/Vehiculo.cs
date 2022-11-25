using System.ComponentModel.DataAnnotations;
namespace Vehiculos_20200091.Data.Models;

public class Vehiculo
{
    [Key]
    public int vehiculoID { get; set; }
    public int MarcaId { get; set; }
    public VehiculoMarca? Marca { get; set; }
    public int ModeloId { get; set; }
    public VehiculoModelo? Modelo { get; set; }
    public int AñoId { get; set; }
    public virtual VehiculoAño? Año { get; set; }
    public string? Color { get; set; }
}


public class VehiculoAño
{
    [Key]
    public int Id { get; set; } 
    public int Año { get; set; } 
}

public class VehiculoMarca{
    [Key]
    public int MarcaId{get; set;}
    public string? Marca {get; set;}
}
public class VehiculoModelo{
    [Key]
    public int ModeloId{get; set;}
    public string? Modelo {get; set;}
}