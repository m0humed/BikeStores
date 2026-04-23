using System;
using System.Collections.Generic;

namespace BikeStores.Repository.Entities;

public partial class OrderAuditLog
{
    public int AuditId { get; set; }

    public int? OrderId { get; set; }

    public string? ActionType { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? UserName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }
}
