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
                VehiculoMarca.Crear("Tacoma"),
                VehiculoMarca.Crear("Honda"),
                VehiculoMarca.Crear("Ford")
            };
            database.VehiculosMarcas.AddRange(vehiculosMarcas);
            await database.SaveChangesAsync();
        }

        if(!database.VehiculosModelos.Any())
        {
            var vehiculosModelos = new List<VehiculoModelo>(){
                VehiculoModelo.Crear("Tacoma"),
                VehiculoModelo.Crear("Hilux"),
                VehiculoModelo.Crear("CRV"),
                VehiculoModelo.Crear("Ridgeline"),
                VehiculoModelo.Crear("Ranger"),
                VehiculoModelo.Crear("Raptor")
,
            };
            database.VehiculosModelos.AddRange(vehiculosModelos);
            await database.SaveChangesAsync();
        }
        if (!database.VehiculosColores.Any())
        {
            var vehiculosColores = new List<VehiculoColor>(){
                VehiculoColor.Crear("Rojo"),
                VehiculoColor.Crear("Azul"),
                VehiculoColor.Crear("Verde"),
                VehiculoColor.Crear("Naranja"),
                VehiculoColor.Crear("Blanco"),
                VehiculoColor.Crear("Negro")
            };
            database.VehiculosColores.AddRange(vehiculosColores);
            await database.SaveChangesAsync();
        }
    }
}