using Vehiculos_20200091.Data.Models;

namespace Vehiculos_20200091.Data.Context;

public class VehiculosSeeder
{
    public static async void Inicializar(IVehiculosDbContext database)
    {
        //Si la tabla de la base de datos no posee registros, registramos las ciudades pre-iniciales.

        if(!database.VehiculosMarcas.Any())
        {
            var vehiculosMarcas = new List<VehiculoMarca>(){
                VehiculoMarca.Crear("Toyota")
            };
            database.VehiculosMarcas.AddRange(vehiculosMarcas);
            await database.SaveChangesAsync();
        }

        if(!database.VehiculosModelos.Any())
        {
            var vehiculosModelos = new List<VehiculoModelo>(){
                VehiculoModelo.Crear("CRV")
            };
            database.VehiculosModelos.AddRange(vehiculosModelos);
            await database.SaveChangesAsync();
        }
        if (!database.VehiculosColores.Any())
        {
            var vehiculosColores = new List<VehiculoColor>(){
                VehiculoColor.Crear("Rojo"),
                VehiculoColor.Crear("Azul"),
                VehiculoColor.Crear("Verde")
            };
            database.VehiculosColores.AddRange(vehiculosColores);
            await database.SaveChangesAsync();
        }
    }
}