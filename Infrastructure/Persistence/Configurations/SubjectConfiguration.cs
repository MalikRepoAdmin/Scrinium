using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        // Rule 1: Primary Key
        builder.HasKey(s => s.Id);

        // Rule 2: Relationships and Cascade Rules
        builder
            .HasMany(s => s.Collections)
            .WithOne(c => c.Subject)
            .HasForeignKey(c => c.SubjectId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(s => s.Materials)
            .WithOne(m => m.Subject)
            .HasForeignKey(m => m.SubjectId)
            .OnDelete(DeleteBehavior.Cascade);

        // Rule 3: Other Property Constraints
        builder.Property(s => s.SubjectName).IsRequired().HasMaxLength(45);
    }
}
