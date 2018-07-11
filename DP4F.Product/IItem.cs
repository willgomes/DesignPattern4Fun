using System;
using System.Collections.Generic;
using System.Text;

namespace DP4F.Product
{
    public interface IItem
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
    }
}
