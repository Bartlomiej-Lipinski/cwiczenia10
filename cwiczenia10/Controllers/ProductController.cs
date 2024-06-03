using cwiczenia10.ResponseModels;
using cwiczenia10.Services;
using Microsoft.AspNetCore.Mvc;

namespace cwiczenia10.Controllers;
[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct(GetProductsResponseModel productsResponseModel)
    {
        var result = await _productService.AddProductAsync(productsResponseModel);
        if (result)
        {
            return Ok();
        }
        else
        {
            return BadRequest();
        }
    }
}