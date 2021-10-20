using Microsoft.EntityFrameworkCore;

namespace RotRut.Server.Data;

public class RotRutContext : DbContext
{
    public RotRutContext(DbContextOptions options) : base(options)
    {

    }

#nullable disable

    public DbSet<Account> Accounts { get; set; }

    public DbSet<Verification> Verifications { get; set; }

    public DbSet<Entry> Entries { get; set; }

#nullable restore
}
