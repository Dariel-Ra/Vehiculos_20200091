using Microsoft.EntityFrameworkCore;
using Vehiculos_20200091.Data.Context;
using Vehiculos_20200091.Data.Models;

namespace Vehiculos_20200091.Data.Services;

public interface IModeloServices
{
    Task<List<VehiculoModelo>> Consultar();
}

public class ModeloServices : IModeloServices
{
    private readonly IVehiculosDbContext context;
    
    public ModeloServices(IVehiculosDbContext context)
    {
        this.context = context;
    }

    public async Task<List<VehiculoModelo>>Consultar()
    {
        try
        {
            var modelo = await context.VehiculoModelos.ToListAsync();
            return modelo;
        }
        catch
        {
            return new List<VehiculoModelo>();
        }
    }
}