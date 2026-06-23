using System;
using System.Collections.Generic;

public sealed class Collection
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public required string Name { get; set; }

    // Foreign Key & Navigation Property: Belongs To Subject
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;

    // Navigation Property: One-To-Many
    public ICollection<Material> Materials { get; set; } = [];
}
