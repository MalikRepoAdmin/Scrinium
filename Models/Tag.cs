using System;

public sealed class Tag
{
    
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public required string Name { get; set; }

}