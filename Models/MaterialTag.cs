using System;

public sealed class MaterialTag
{
    // No Guid generation to avoid Material-to-Tag duplication
    // MaterialId and TagId can act as Composite Key instead
    // Foreign Key & Navigation Property: Belongs To Material AND Tag
    public Guid MaterialId { get; init; }
    public Material Material { get; set; } = null!;

    public Guid TagId { get; init; }
    public Tag Tag { get; set; } = null!;
}
