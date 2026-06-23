using System;
using System.Collections.Generic;

public sealed class Subject
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public required string SubjectName { get; set; }

    // Foreign Key & Navigation Property: Belongs To Library
    public Guid LibraryId { get; set; }
    public Library Library { get; set; } = null!;

    // Navigation Property: One-To-Many
    public ICollection<Material> Materials { get; set; } = [];
    public ICollection<Collection> Collections { get; set; } = [];
}
