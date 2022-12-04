using Microsoft.EntityFrameworkCore;
using Vehiculos_20200091.Data.Context;
using Vehiculos_20200091.Data.Models;

namespace Vehiculos_20200091.Data.Services;

public interface IMarcaService
{
    Task<List<VehiculoMarca>> Consultar();
}

public class MarcaService : IMarcaService
{
    private readonly IVehiculosDbContext context;

    public MarcaService(IVehiculosDbContext context)
    {
        this.context = context;
    }

    public async Task<List<VehiculoMarca>> Consultar()
    {
        try
        {
            var marcas = await context.VehiculosMarcas.ToListAsync();
            return marcas;
        }
        catch
        {
            return new List<VehiculoMarca>();
        }
    }
}