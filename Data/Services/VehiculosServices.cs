using Vehiculos_20200091.Data.Context;
using Vehiculos_20200091.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos_20200091.Data.Services;

public interface IVehiculosServices
{
    Task<Result<List<Vehiculo>>> Consultar(string filtro);
    Task<Result<int>> Registrar(Vehiculo datos);
}

public class VehiculosServices : IVehiculosServices
{
    private IVehiculosDbContext context;
    public VehiculosServices(IVehiculosDbContext context)
    {
        this.context = context;
    }

    public async Task<Result<int>> Registrar(Vehiculo datos)
    {
        try
        {
            var vehiculos = Vehiculo.Crear(datos);

            context.Vehiculos.Add(vehiculos);
            await context.SaveChangesAsync(new());

            return Result<int>.Success(vehiculos.vehiculoID);
        }
        catch (Exception E)
        {
            return Result<int>.Failed(E.Message);
        }
    }

    public async Task<Result<List<Vehiculo>>> Consultar(string filtro)
    {
        try
        {
            //Se consulta en la base de datos segun el nombre del contacto y el telefono.
            var vehiculosDB =
            await context.Vehiculos.Where(p =>p.vehiculoID.ToString().Contains(filtro)
            )
            .Include(vehiculos => vehiculos.Marca)
            .Include(vehiculos => vehiculos.Modelo)
            .Include(vehiculos => vehiculos.Color)
            .ToListAsync(new());
            var vehiculosMapeados = vehiculosDB.Select(c => new Vehiculo()
            {
                vehiculoID = c.vehiculoID,
                Marca = new VehiculoMarca() {/*MarcaId = c.Marca!.MarcaId,*/Marca = c.Marca!.Marca },
                Modelo = new VehiculoModelo() {Modelo = c.Modelo!.Modelo },
                Año = c.Año,
                Color = new VehiculoColor() {Color = c.Color!.Color}
            })
                .ToList();
            return Result<List<Vehiculo>>.Success(vehiculosMapeados);
        }
        catch (Exception E)
        {
            return Result<List<Vehiculo>>.Failed(E.Message);
        }
    }
}
