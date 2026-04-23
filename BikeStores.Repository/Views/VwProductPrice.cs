using System;
using System.Collections.Generic;

namespace BikeStores.Repository.Views;

public partial class VwProductPrice
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal ListPrice { get; set; }
}
