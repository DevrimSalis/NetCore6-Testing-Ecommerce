using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Contact : BaseEntity, IEntity
    {
        public string? Location { get; set; }
        public string? Address { get; set; }
        public string? MobileNumber { get; set; }
        public string? HotLineNumber { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
    }
}
