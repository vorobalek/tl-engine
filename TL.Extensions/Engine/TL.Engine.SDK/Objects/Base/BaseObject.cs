namespace TL.Engine.SDK.Objects
{
    public abstract class BaseObject : IBaseObject
    {
        protected abstract string _Description { get; }

        public virtual string GetDescription() => _Description;
    }
}
