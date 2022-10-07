using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
