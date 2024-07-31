using System;
using System.Collections.Generic;

namespace RestaurantApi.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
