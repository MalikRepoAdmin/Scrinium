using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class CollectionConfiguration : IEntityTypeConfiguration<Collection>
{
    public void Configure(EntityTypeBuilder<Collection> builder)
    {
        // Rule 1: Primary Key
        builder.HasKey(c => c.Id);

        // Rule 2: Relationships and Cascade Rules
        builder
            .HasMany(c => c.Materials)
            .WithOne(m => m.Collection)
            .HasForeignKey(m => m.CollectionId)
            .OnDelete(DeleteBehavior.Cascade);

        // Rule 3: Other Property Constraints
        builder.Property(c => c.Name).IsRequired().HasMaxLength(45);
    }
}
