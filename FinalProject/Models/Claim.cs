using System;
using System.Collections.Generic;

namespace FinalProject.Models;

public partial class Claim
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Date { get; set; }

    public int VehicleId { get; set; }

    public virtual Vehicle Vehicle { get; set; } = null!;
}
