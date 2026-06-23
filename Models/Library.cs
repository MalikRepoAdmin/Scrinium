using System;
using System.Collections.Generic;

public sealed class Library
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public required string LibraryName { get; set; }

    // Navigation Property: One-to-Many
    public ICollection<Subject> Subjects { get; set; } = [];
}
