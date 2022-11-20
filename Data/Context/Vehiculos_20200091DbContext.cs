using Vehiculos_20200091.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos_20200091.Data.Context;

public class Vehiculos_20200091DbContext:DbContext,IVehiculos_20200091DbContext
{
    public Vehiculos_20200091DbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Vehiculo> Vehiculos {get; set;} = null!;

}

public interface IVehiculos_20200091DbContext
{

    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
