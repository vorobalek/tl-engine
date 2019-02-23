namespace TL.Engine.SDK.Entities
{
    public abstract class Entity : IEntity
    {
        public virtual bool IsDeleted { get; set; } = false;
    }
}
