using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities.Abstract
{
    public abstract class BaseUser : BaseEntity
    {
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual byte[]? PasswordHash { get; set; }
        public virtual string? Image { get; set; }
    }
}
