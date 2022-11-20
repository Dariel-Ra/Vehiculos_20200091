using System.ComponentModel.DataAnnotations;
namespace Vehiculos_20200091.Data.Models;

public class Vehiculo
{
    [Key]
    public int vehiculoID { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Año { get; set; }
    public string? Color { get; set; }
}

/*
public class VehiculoMarca
{
    [Key]
    public int Id { get; set; } 
    public string Nombre { get; set; } = null!;
}

public class VehiculoModelo
{
    [Key]
    public int Id { get; set; } 
    public int MarcaId { get; set; } 
    public string Marca { get; set; }
    public string Nombre { get; set; }= null!;
}

public class VehiculoAño
{
    [Key]
    public int Id { get; set; } 
    public int Año { get; set; } 
}
*/