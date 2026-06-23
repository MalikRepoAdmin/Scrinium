using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class LibraryConfiguration : IEntityTypeConfiguration<Library>
{
    public void Configure(EntityTypeBuilder<Library> builder)
    {
        // Rule 1: Primary Key
        builder.HasKey(l => l.Id);

        // Rule 2: Relationships and Cascade Rules
        builder
            .HasMany(l => l.Subjects)
            .WithOne(s => s.Library)
            .HasForeignKey(s => s.LibraryId)
            .OnDelete(DeleteBehavior.Cascade);

        // Rule 3: Other Property Constraints
        builder.Property(l => l.LibraryName).IsRequired().HasMaxLength(25);
    }
}
