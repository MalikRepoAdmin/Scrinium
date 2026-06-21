using System;

public sealed class Subject
{
    
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public Guid LibraryId { get; set; }
    public required string SubjectName { get; set; }

}
