using System;

public sealed class Material
{
    
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public Guid SubjectId { get; set; }
    public Guid? CollectionId { get; set; }
    public required string Title { get; set; }
    public required string FilePath { get; set; }

}
