namespace ProjectTemplate.Core.DomainModel.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
