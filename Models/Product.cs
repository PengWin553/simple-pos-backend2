public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public float? Price { get; set; }
    public int? Stock { get; set; }
    public string? Unit { get; set; }
    public string? Sku { get; set; }
    public int? CategoryId { get; set; }
    // public string? CategoryName { get; set; }

    //  // Navigation property to link with Category
    // public required Category Category { get; set; }

    // // Navigation property to link with TransactionProduct
    // public required ICollection<TransactionProduct> TransactionProducts { get; set; }
}