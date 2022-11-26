using Vehiculos_20200091.Data.Models;

namespace Vehiculos_20200091.Data.Context;

public class Vehiculos_20200091Seeder
{
    public static async void Inicializar(IVehiculos_20200091DbContext database)
    {
        //Si la tabla de la base de datos no posee registros, registramos las ciudades pre-iniciales.
        if(!database.VehiculosAños.Any())
        {
            var vehiculosAños = new List<VehiculoAño>(){
                VehiculoAño.Crear(2014),
                VehiculoAño.Crear(2015),
                VehiculoAño.Crear(2016),
                VehiculoAño.Crear(2017),
                VehiculoAño.Crear(2018),
                VehiculoAño.Crear(2019),
                VehiculoAño.Crear(2020),
                VehiculoAño.Crear(2021),
                VehiculoAño.Crear(2022),
                VehiculoAño.Crear(2023)
            };
            database.VehiculosAños.AddRange(vehiculosAños);
            await database.SaveChangesAsync();
        }

        if(!database.VehiculoMarcas.Any())
        {
            var vehiculosMarcas = new List<VehiculoMarca>(){
                VehiculoMarca.Crear("Toyota")
            };
            database.VehiculoMarcas.AddRange(vehiculosMarcas);
            await database.SaveChangesAsync();
        }

        if(!database.VehiculoModelos.Any())
        {
            var vehiculosModelos = new List<VehiculoModelo>(){
                VehiculoModelo.Crear("CRV")
            };
            database.VehiculoModelos.AddRange(vehiculosModelos);
            await database.SaveChangesAsync();
        }
    }
}