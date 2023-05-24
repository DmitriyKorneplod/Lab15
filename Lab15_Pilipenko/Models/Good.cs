using System;
using System.Collections.Generic;

namespace Lab15_Pilipenko.Models;

public partial class Good
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Price { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
