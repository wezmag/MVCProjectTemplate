using ProjectTemplate.Core.DomainModel;
using ProjectTemplate.Data.Common;
using ProjectTemplate.Service.Common;
using ProjectTemplate.Service.Interface;

namespace ProjectTemplate.Service
{
    public class SampleService : EntityService<Sample>, ISampleService
    {
        public SampleService(IUnitOfWork unitOfWork, IGenericRepository<Sample> repository) : base(unitOfWork, repository)
        {
        }
    }
}
