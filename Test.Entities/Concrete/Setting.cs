using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Setting : BaseEntity, IEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Meta { get; set; }
        public string? PhoneNumber { get; set; }
        public string? WorkDate { get; set; }
        public string? Email { get; set; }
    }
}
