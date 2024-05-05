namespace T70.Tests.AliExpressDataHub.Models;

public class ItemProp
{
    public int Pid { get; set; }

    public string? Name { get; set; }

    public ItemPropValue[]? Values { get; set; }
}
