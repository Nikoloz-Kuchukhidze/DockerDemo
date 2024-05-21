using DockerDemo.API.Contracts;

namespace DockerDemo.API.Entities;

public class Product
{
    private Product()
    {
        
    }

    public Product(CreateProductRequest request)
    {
        Name = request.Name;
        Price = request.Price;
        Quantity = request.Quantity;
    }


    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
