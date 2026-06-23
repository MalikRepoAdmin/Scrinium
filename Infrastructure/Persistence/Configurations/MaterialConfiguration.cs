using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class MaterialConfiguration : IEntityTypeConfiguration<Material>
{
    public void Configure(EntityTypeBuilder<Material> builder)
    {
        // Rule 1: Primary Key
        builder.HasKey(m => m.Id);

        // Rule 2: Relationships and Cascade Rules
        builder
            .HasOne(m => m.MaterialContent)
            .WithOne(mc => mc.Material)
            .HasForeignKey<MaterialContent>(mc => mc.MaterialId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(m => m.MaterialTags)
            .WithOne(mt => mt.Material)
            .HasForeignKey(mt => mt.MaterialId)
            .OnDelete(DeleteBehavior.Cascade);

        // Rule 3: Other Property Constraints
        builder.Property(m => m.Title).IsRequired().HasMaxLength(75);
        builder.Property(m => m.FilePath).IsRequired();
    }
}
