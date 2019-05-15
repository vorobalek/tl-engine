namespace TL.Engine.SDK.Actions
{
    public interface IStartupAction
    {
        bool IsBlocker { get; }
        int Priority { get; }
        string Description { get; }
        IStartupActionResult Invoke();
    }
}
