using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class MaterialTagConfiguration : IEntityTypeConfiguration<MaterialTag>
{
    public void Configure(EntityTypeBuilder<MaterialTag> builder)
    {
        // Rule 1: Primary Key
        builder.HasKey(mt => new { mt.MaterialId, mt.TagId });

        // Rule 2: Relationships and Cascade Rules

        // Rule 3: Other Property Constraints
    }
}
