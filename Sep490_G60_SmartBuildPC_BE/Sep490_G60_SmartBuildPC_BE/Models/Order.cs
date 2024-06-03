﻿using System;
using System.Collections.Generic;

namespace Sep490_G60_SmartBuildPC_BE.Models
{
    public partial class Order
    {
        public Order()
        {
            Bills = new HashSet<Bill>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; } = null!;
        public string? OrderAddress { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
