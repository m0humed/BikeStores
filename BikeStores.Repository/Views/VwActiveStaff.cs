using System;
using System.Collections.Generic;

namespace BikeStores.Repository.Views;

public partial class VwActiveStaff
{
    public int StaffId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public byte Active { get; set; }
}
