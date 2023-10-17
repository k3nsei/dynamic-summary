namespace DynamicSummary;

public readonly record struct CurrencyNodeProps(string Label, string? ID = null);

public readonly record struct Currency(string Code, decimal Amount);

public class CurrencyNodeBuilder : BaseNodeBuilder
{
    protected readonly CurrencyNodeProps Props;

    protected readonly Currency Value;

    public CurrencyNodeBuilder(CurrencyNodeProps props, Currency value) : base("currency")
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
            value = Value
        };
    }
}