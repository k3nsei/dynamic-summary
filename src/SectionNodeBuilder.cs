namespace DynamicSummary;

public readonly record struct SectionNodeProps(string Title);

public class SectionNodeBuilder : BaseNodeBuilder
{
    protected readonly SectionNodeProps Props;

    public SectionNodeBuilder(SectionNodeProps props, IEnumerable<object>? children) : base("section", children)
    {
        Props = props;
    }

    public override object Build()
    {
        return new
        {
            type = Type,
            props = new
            {
                title = Props.Title
            },
            children = Children?.ToArray()
        };
    }
}