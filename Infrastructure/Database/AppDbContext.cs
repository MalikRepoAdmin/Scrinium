using System.Reflection;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    // options is passed to the parent DbContext via base(options)
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    /*
        Database Entity for Domain Model Definition
        Is used to perform LINQ queries
    */

    // Main Domain Models
    public DbSet<Library> Libraries { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Collection> Collections { get; set; }
    public DbSet<Material> Materials { get; set; }

    // Supporting Domain Models
    public DbSet<MaterialContent> MaterialContents { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<MaterialTag> MaterialTags { get; set; }

    /*
        Override OnModelCreating
        To apply All Configurations in project Assembly
    */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
