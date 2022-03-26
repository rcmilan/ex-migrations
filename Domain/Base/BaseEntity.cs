namespace Domain.Base
{
    public class BaseEntity
    {
    }

    public class BaseEntity<TId> : BaseEntity
    {
        public TId Id { get; set; }
    }
}