using cwiczenia10.Contexts;
using cwiczenia10.Exeptions;
using cwiczenia10.ResponseModels;
using cwiczenia10.Models;
using Microsoft.EntityFrameworkCore;

namespace cwiczenia10.Services;

public class ProductService(DataBaseContext context) : IProductService
{
    public async Task<bool> AddProductAsync(GetProductsResponseModel newProduct)
    {
        var product = new Products
        {
            Name = newProduct.Name,
            Weight = newProduct.weight,
            Width = newProduct.width,
            Height = newProduct.height,
            Depth = newProduct.depth
        };

        context.Products.Add(product);
        await context.SaveChangesAsync();

        return true;
    }
    
}