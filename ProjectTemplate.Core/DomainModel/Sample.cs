using ProjectTemplate.Core.DomainModel.Common;

namespace ProjectTemplate.Core.DomainModel
{
    public class Sample : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
