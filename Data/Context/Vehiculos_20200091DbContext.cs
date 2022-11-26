using Vehiculos_20200091.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos_20200091.Data.Context;

public class Vehiculos_20200091DbContext:DbContext,IVehiculos_20200091DbContext
{
    public Vehiculos_20200091DbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Vehiculo> Vehiculos {get; set;} = null!;
    public virtual DbSet<VehiculoAño> VehiculosAños {get; set;} = null!;
    public virtual DbSet<VehiculoMarca> VehiculoMarcas {get; set;} = null!;
    public virtual DbSet<VehiculoModelo> VehiculoModelos {get; set;} = null!;
    
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}

public interface IVehiculos_20200091DbContext
{
    public DbSet<Vehiculo> Vehiculos {get; set;}
    public DbSet<VehiculoAño> VehiculosAños {get; set;}
    public DbSet<VehiculoMarca> VehiculoMarcas {get; set;}
    public DbSet<VehiculoModelo> VehiculoModelos {get; set;}
    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
