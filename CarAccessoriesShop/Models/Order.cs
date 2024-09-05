using System;
using System.Collections.Generic;

namespace CarAccessoriesShop.Models
{
    public class Order
    {
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}