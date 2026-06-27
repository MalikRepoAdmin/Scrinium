using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        var comparer = new ValueComparer<List<string>>(
            (left, right) => left!.SequenceEqual(right!),
            list => list.Aggregate(0, (hash, value) => HashCode.Combine(hash, value.GetHashCode())),
            list => list.ToList()
        );

        builder
            .Property(mc => mc.Keywords)
            .IsRequired()
            .HasConversion(
                keywords => JsonSerializer.Serialize(keywords, (JsonSerializerOptions?)null),
                json =>
                    JsonSerializer.Deserialize<List<string>>(json, (JsonSerializerOptions?)null)
                    ?? new List<string>()
            )
            .Metadata.SetValueComparer(comparer);
        ;
    }
}
