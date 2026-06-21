using System;
using System.Collections.Generic;

public sealed class MaterialContent
{
    
    public Guid MaterialId { get; set; }

    public string RawText { get; set; } = "";
    public string? Summary { get; set; }
    public List<string> Keywords { get; set; } = [];

}
