using CRUD_Blazor_Excel.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Blazor_Excel.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    
    public DbSet<Empregado> Empregados { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    } 
    
}

