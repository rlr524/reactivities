using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    
    // DbSet is what EF > DbContext uses to create a table in the DB, related to a specific Domain (e.g. Activity).
    // The name of the prop we set up using DbSet<Domain> is the name of the table that EF will create.
    public DbSet<Activity> Activities { get; set; }
}