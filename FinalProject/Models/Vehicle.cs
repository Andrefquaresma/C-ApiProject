using System;
using System.Collections.Generic;

namespace FinalProject.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Vin { get; set; } = null!;

    public string Color { get; set; } = null!;

    public int Year { get; set; }

    public int OwnerId { get; set; }

    public virtual ICollection<Claim> Claims { get; } = new List<Claim>();

    public virtual Owner Owner { get; set; } = null!;
}
