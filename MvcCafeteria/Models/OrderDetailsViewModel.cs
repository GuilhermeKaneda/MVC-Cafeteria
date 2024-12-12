using MvcCafeteria.Models;

public class OrderDetailsViewModel
{
    public required Order Order { get; set; }
    public required Dictionary<Product, int> Products { get; set; }
}