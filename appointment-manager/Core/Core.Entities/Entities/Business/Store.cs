using Core.Model.Entities.Common;

namespace Core.Model.Entities.Business
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
    }
}
