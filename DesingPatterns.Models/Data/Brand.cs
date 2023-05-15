using System;
using System.Collections.Generic;

namespace DesingPatterns.Models.Data;

public partial class Brand
{
    public Guid BrandId { get; set; }

    public string Name { get; set; } = null!;
}
