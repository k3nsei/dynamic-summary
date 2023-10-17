namespace DynamicSummary;

public readonly record struct TextNodeProps(string Label, string? ID = null);

public class TextNodeBuilderBuilder : BaseNodeBuilder
{
    private readonly TextNodeProps Props;

    private readonly string Value;

    public TextNodeBuilderBuilder(TextNodeProps props, string value) : base("text")
    {
        Props = props;
        Value = value;
    }

    public override object Build()
    {
        var data = new
        {
            type = Type,
            props = new
            {
                id = Props.ID,
                label = Props.Label
            },
            value = Value
        };

        return data;
    }
}