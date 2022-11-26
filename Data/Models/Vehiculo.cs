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
    public virtual VehiculoAño? Año { get; set; } = null!;
    public string? Color { get; set; }

    public static Vehiculo Crear(int marcaId, int modeloId, int añoId, string color) => new Vehiculo()
    {
        vehiculoID = 0,
        MarcaId = marcaId,
        ModeloId = modeloId,
        AñoId = añoId,
        Color = color
    };

    internal void Update(int marcaId, int modeloId, int añoId, string color)
    {
        throw new NotImplementedException();
    }
}

public class VehiculoAño
{
    [Key]
    public int Id { get; set; } 
    public int Año { get; set; } 

    public static VehiculoAño Crear(int año)
    =>new VehiculoAño(){Año = año};
}

public class VehiculoMarca{
    [Key]
    public int MarcaId{get; set;}
    public string? Marca {get; set;}
    public static VehiculoMarca Crear(string marca) 
    =>new VehiculoMarca(){Marca = marca};
}
public class VehiculoModelo{
    [Key]
    public int ModeloId{get; set;}
    public string? Modelo {get; set;}
    public static VehiculoModelo Crear(string modelo)
    =>new VehiculoModelo(){Modelo = modelo};
}