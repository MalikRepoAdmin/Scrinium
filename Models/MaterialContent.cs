using System;
using System.Collections.Generic;

public sealed class MaterialContent
{
    // No Guid generation
    // MaterialId can act as Primary Key instead
    public string RawText { get; set; } = "";
    public string? Summary { get; set; }

    // TODO: List properties would need Converter into JSON, because we cannot store list directly into Database
    public List<string> Keywords { get; set; } = [];

    // Foreign Key & Navigation Property: Belongs To Material
    public Guid MaterialId { get; set; }
    public Material Material { get; set; } = null!;
}
