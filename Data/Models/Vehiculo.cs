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
    public int ColorId { get; set; }
    public VehiculoColor? Color {get; set; }

    public static Vehiculo Crear(Vehiculo datos) => 
    new (){
        vehiculoID = 0,
        MarcaId = datos.MarcaId,
        ModeloId = datos.ModeloId,
        Año = datos.Año,
        ColorId = datos.ColorId,
    };

    internal void Update(int marcaId, int modeloId, int año, int colorId)
    {
        throw new NotImplementedException();
    }
}
