// Cart.cs
using System.Collections.Generic;

public class Cart
{
    public List<Product> Products { get; set; }

    public Cart()
    {
        Products = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        Products.Add(product);
    }
}
