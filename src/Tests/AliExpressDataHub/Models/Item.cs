namespace T70.Tests.AliExpressDataHub.Models;

public class Item
{
    public string? ItemId { get; set; }
    public string? Title { get; set; }
    public int CatId { get; set; }
    public string? Sales { get; set; }
    public int WishCount { get; set; }
    public string? ItemUrl { get; set; }
    public string[]? Images { get; set; }
    public ItemVideo? Video { get; set; }
    public ItemProperty? Properties { get; set; }
    public ItemDescription? Description { get; set; }
    public ItemSku? Sku { get; set; }
}
