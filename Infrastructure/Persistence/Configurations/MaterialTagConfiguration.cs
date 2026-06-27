using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class MaterialTagConfiguration : IEntityTypeConfiguration<MaterialTag>
{
    public void Configure(EntityTypeBuilder<MaterialTag> builder)
    {
        // Rule 1: Primary Key & Indexes
        builder.HasKey(mt => new { mt.MaterialId, mt.TagId });
        builder.HasIndex(mt => new { mt.TagId, mt.MaterialId });

        // Rule 2: Relationships and Cascade Rules

        // Rule 3: Other Property Constraints
    }
}
