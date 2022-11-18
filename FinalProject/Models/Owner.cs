using System;
using System.Collections.Generic;

namespace FinalProject.Models;

public partial class Owner
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string DriverLicense { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();
}
