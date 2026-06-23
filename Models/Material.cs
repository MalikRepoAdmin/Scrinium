using System;
using System.Collections.Generic;

public sealed class Material
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public required string Title { get; set; }
    public required string FilePath { get; set; }

    // Foreign Key & Navigation Property: Belongs To Subject OR Collection
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;

    public Guid? CollectionId { get; set; }
    public Collection? Collection { get; set; }

    // Navigation Property: One-To-One & One-To-Many
    public MaterialContent? MaterialContent { get; set; }
    public ICollection<MaterialTag> MaterialTags { get; set; } = [];
}
