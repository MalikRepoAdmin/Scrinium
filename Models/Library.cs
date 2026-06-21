using System;

public sealed class Library
{

    public Guid Id { get; init; } = Guid.CreateVersion7();
    public required string LibraryName { get; set; }

}