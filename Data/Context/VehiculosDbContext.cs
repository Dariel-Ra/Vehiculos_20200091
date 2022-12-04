using Vehiculos_20200091.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos_20200091.Data.Context;

public class VehiculosDbContext:DbContext,IVehiculosDbContext
{
    public VehiculosDbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Vehiculo> Vehiculos {get; set;} = null!;
    public virtual DbSet<VehiculoMarca> VehiculosMarcas {get; set;} = null!;
    public virtual DbSet<VehiculoModelo> VehiculosModelos {get; set;} = null!;
    public virtual DbSet<VehiculoColor> VehiculosColores {get; set;} = null!;
    
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}

public interface IVehiculosDbContext
{
    public DbSet<Vehiculo> Vehiculos {get; set;}
    public DbSet<VehiculoMarca> VehiculosMarcas {get; set;}
    public DbSet<VehiculoModelo> VehiculosModelos {get; set;}
    public DbSet<VehiculoColor> VehiculosColores {get; set;}
    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
