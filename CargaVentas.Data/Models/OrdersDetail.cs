
using System;
using System.Collections.Generic;

namespace CargaVentas.Data.Models;

public partial class OrdersDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? TotalPrice { get; set; }
}