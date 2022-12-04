using Microsoft.EntityFrameworkCore;
using Vehiculos_20200091.Data.Context;
using Vehiculos_20200091.Data.Models;

namespace Vehiculos_20200091.Data.Services;

public interface IColorServices
{
    Task<List<VehiculoColor>> Consultar();
}

public class ColorServices : IColorServices
{
    private readonly IVehiculosDbContext context;
    
    public ColorServices(IVehiculosDbContext context)
    {
        this.context = context;
    }

    public async Task<List<VehiculoColor>>Consultar()
    {
        try
        {
            var color = await context.VehiculosColores.ToListAsync();
            return color;
        }
        catch
        {
            return new List<VehiculoColor>();
        }
    }
}