namespace DynamicSummary;

public class RootNodeBuilder : BaseNodeBuilder
{
    public RootNodeBuilder(IEnumerable<object> children) : base("root", children)
    {
    }

    public override object Build()
    {
        return Children is null ? Array.Empty<object>() : Children.ToArray();
    }
}