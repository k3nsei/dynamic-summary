namespace DynamicSummary;

public abstract class BaseNodeBuilder
{
    protected readonly string Type;

    protected readonly IEnumerable<object>? Children;

    protected BaseNodeBuilder(string type, IEnumerable<object>? children = null)
    {
        Type = type;
        Children = children;
    }

    public abstract object Build();
}