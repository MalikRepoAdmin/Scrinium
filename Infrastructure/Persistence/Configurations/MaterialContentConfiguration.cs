using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class MaterialContentConfiguration : IEntityTypeConfiguration<MaterialContent>
{
    public void Configure(EntityTypeBuilder<MaterialContent> builder)
    {
        // Rule 1: Primary Key
        builder.HasKey(mc => mc.MaterialId);

        // Rule 2: Relationships and Cascade Rules

        // Rule 3: Other Property Constraints
        builder.Property(mc => mc.RawText).IsRequired();
        builder.Property(mc => mc.Summary).HasSentinel("");
        // TODO: Create Converter to Serialize and Deserialize ICollection into and from JSON
        builder
            .Property(mc => mc.Keywords)
            .IsRequired() /* .HasConversion() */
        ;
    }
}
