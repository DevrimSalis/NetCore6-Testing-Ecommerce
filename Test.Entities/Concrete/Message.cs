using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Message : BaseEntity, IEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
    }
}
