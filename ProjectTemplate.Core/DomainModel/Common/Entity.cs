namespace ProjectTemplate.Core.DomainModel.Common
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
