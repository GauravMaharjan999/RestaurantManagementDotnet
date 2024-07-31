using System;
using System.Collections.Generic;

namespace RestaurantApi.Models;

public partial class Order
{
    public long OrderId { get; set; }

    public string? OrderNo { get; set; }

    public int? CustomerId { get; set; }

    public string? Pmethod { get; set; }

    public decimal? Gtotal { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
