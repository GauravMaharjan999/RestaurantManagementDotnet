using System;
using System.Collections.Generic;

namespace RestaurantApi.Models;

public partial class OrderItem
{
    public long OrderItemId { get; set; }

    public long? OrderId { get; set; }

    public int? ItemId { get; set; }

    public int? Quantity { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Order? Order { get; set; }
}
