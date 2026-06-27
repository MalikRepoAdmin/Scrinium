using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        // Rule 1: Primary Key
        builder.HasKey(t => t.Id);

        // Rule 2: Relationships and Cascade Rules
        builder
            .HasMany(t => t.MaterialTags)
            .WithOne(mt => mt.Tag)
            .HasForeignKey(mt => mt.TagId)
            .OnDelete(DeleteBehavior.Cascade);

        // Rule 3: Other Property Constraints
        builder.Property(t => t.Name).IsRequired().HasMaxLength(20).UseCollation("NOCASE");
    }
}
