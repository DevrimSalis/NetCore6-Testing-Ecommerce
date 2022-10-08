using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Product : BaseEntity, IEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Dimension { get; set; }
        public int ViewCount { get; set; } = 0;
        public int Star { get; set; }
        public string? MainImage { get; set; }
        public string? Images { get; set; }
        public int Discount { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int AdminId { get; set; }
        public Admin? Admin { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }

    }
}
