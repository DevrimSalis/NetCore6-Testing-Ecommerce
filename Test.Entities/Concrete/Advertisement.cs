using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Advertisement : BaseEntity, IEntity
    {
        public string? CompanyName { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? ForwardingAddress { get; set; }
    }
}
