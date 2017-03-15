using ProjectTemplate.Core.DomainModel;
using ProjectTemplate.Data.Common;
using ProjectTemplate.Data.Interface;

namespace ProjectTemplate.Data.Repository
{
    public class SampleRepository : GenericRepository<Sample>, ISampleRepository
    {
        public SampleRepository(IDataContext context) : base(context)
        {
        }
    }
}
