using cwiczenia10.ResponseModels;

namespace cwiczenia10.Services;

public interface IProductService
{
    Task<bool> AddProductAsync(GetProductsResponseModel newProduct);
}