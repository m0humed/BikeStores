using System;
using System.Collections.Generic;

namespace BikeStores.Repository.Views;

public partial class VwCustomerOrderSummary
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public int? TotalOrders { get; set; }
}
