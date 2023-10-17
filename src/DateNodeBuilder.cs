namespace DynamicSummary;

public readonly record struct DateNodeProps(string Label, string? ID = null);

public class DateNodeBuilder : BaseNodeBuilder
{
    protected readonly DateNodeProps Props;

    protected readonly DateTime Value;

    public DateNodeBuilder(DateNodeProps props, DateTime value) : base("date", null)
    {
        Props = props;
        Value = value;
    }

    public override object Build()
    {
        return new
        {
            type = Type,
            props = new
            {
                id = Props.ID,
                label = Props.Label
            },
            value = Value.ToUniversalTime().ToString("o")
        };
    }
}