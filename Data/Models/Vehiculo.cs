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
    public int Año { get; set; }
    public string? Color { get; set; }

    public static Vehiculo Crear(int marcaId, int modeloId, int año, string color) => new Vehiculo()
    {
        vehiculoID = 0,
        MarcaId = marcaId,
        ModeloId = modeloId,
        Año = año,
        Color = color
    };

    internal void Update(int marcaId, int modeloId, int añoId, string color)
    {
        throw new NotImplementedException();
    }
}
