using Vehiculos_20200091.Data.Context;
using Vehiculos_20200091.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos_20200091.Data.Services;

public class Vehiculos_20200091Service : IVehiculos_20200091Service
{
    private readonly IVehiculos_20200091DbContext _context;

    public Vehiculos_20200091Service(IVehiculos_20200091DbContext context)
    {
        _context = context;
    }

    public async Task<Result<int>> Crear(int marcaId, int modeloId, int añoId, string color)
    {
        try
        {
            var vehiculo = Vehiculo.Crear(marcaId, modeloId, añoId, color);
            _context.Vehiculos.Add(vehiculo);
            await _context.SaveChangesAsync();
            return Result<int>.Success(vehiculo.vehiculoID);
        }
        catch (Exception E)
        {
            return Result<int>.Failed(E.Message);
        }
    }
    public async Task<Result<List<Vehiculo>>> Consultar(string filtro = "")
    {
        try
        {
            
            var vehiculo = await _context.Vehiculos
            .Where(p=>p.vehiculoID.ToString().Contains(filtro))
            .ToListAsync();
            
            return Result<List<Vehiculo>>.Success(vehiculo);
        }
        catch (Exception E)
        {
            return Result<List<Vehiculo>>.Failed(E.Message);
        }
    }

    public async Task Editar(int Id,int marcaId, int modeloId, int añoId, string color){
        var vehiculo = await _context.Vehiculos
        .FirstOrDefaultAsync(p=>p.vehiculoID == Id);
        if(vehiculo!=null){
        vehiculo.Update(marcaId, modeloId, añoId, color);
        await _context.SaveChangesAsync();
        }
    }
    public async Task Eliminar(int Id){
        var vehiculo = await _context.Vehiculos
        .FirstOrDefaultAsync(p=>p.vehiculoID == Id);
        if(vehiculo!=null){
        _context.Vehiculos.Remove(vehiculo);
        await _context.SaveChangesAsync();
        }
    }
}

public interface IVehiculos_20200091Service
{
    public Task<Result<int>> Crear(int marcaId, int modeloId, int añoId, string color);
    public Task<Result<List<Vehiculo>>> Consultar(string filtro = "");
    public Task Editar(int Id,int marcaId, int modeloId, int añoId, string color);
    public Task Eliminar(int Id);
}
