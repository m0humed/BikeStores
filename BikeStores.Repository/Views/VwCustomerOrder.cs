using System;
using System.Collections.Generic;

namespace BikeStores.Repository.Views;

public partial class VwCustomerOrder
{
    public int OrderId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public DateOnly OrderDate { get; set; }

    public byte OrderStatus { get; set; }
}
