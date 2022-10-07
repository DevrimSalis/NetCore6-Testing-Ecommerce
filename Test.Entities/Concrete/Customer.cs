using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Customer : BaseUser, IEntity
    {
        public string? UserName { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
