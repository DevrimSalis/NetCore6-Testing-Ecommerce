using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class SocialMedia : BaseEntity
    {
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
    }
}
