using cwiczenia10.ResponseModels;
using cwiczenia10.Services;
using Microsoft.AspNetCore.Mvc;

namespace cwiczenia10.Controllers;
[ApiController]
[Route("api/accounts")]
public class AccountsControler(IAccountService service) : ControllerBase
{
    
    public async Task<IActionResult> getAccountById(int id)
    {
        GetAccountResponseModel? resoult = await service.GetAccountByIdAsync(id);
        if (resoult is null)
        {
            return NotFound();
        }
        return Ok(resoult);
    }
}