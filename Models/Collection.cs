using System;

public sealed class Collection
{
    
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public Guid SubjectId { get; set; }
    public required string Name { get; set; }

}