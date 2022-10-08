using Test.Core.Entities.Abstract;

namespace Test.Entities.Concrete
{
    public class Admin : BaseUser
    {
        public ICollection<Product>? Products { get; set; }
    }
}
