namespace TL.Engine.SDK.Actions
{
    public interface IStartupAction
    {
        int Priority { get; }
        string Description { get; }
        IStartupActionResult Invoke();
    }
}
