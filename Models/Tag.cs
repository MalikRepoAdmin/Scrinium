using System;
using System.Collections.Generic;

public sealed class Tag
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public required string Name { get; set; }

    // Navigation Property: One-To-Many
    public ICollection<MaterialTag> MaterialTags { get; set; } = [];
}
