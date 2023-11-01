using Microsoft.EntityFrameworkCore;
using NeurtoLab.Repository.Model;

namespace NeurtoLab.Repository.EF;
public class EFContext : DbContext
{
    // public EFContext(DbContextOptions options)
    //     : base(options)
    // {
    // }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public virtual DbSet<Employee> Employees { get; set; }
}