using cwiczenia10.Contexts;
using cwiczenia10.Exeptions;
using cwiczenia10.ResponseModels;
using Microsoft.EntityFrameworkCore;

namespace cwiczenia10.Services;

public class AccountService(DataBaseContext context) : IAccountService
{
    public async Task<GetAccountResponseModel> GetAccountByIdAsync(int id)
    {
            var result = await context.Accounts
                .Where(a => a.AccountId == id)
                .Select(a => new GetAccountResponseModel
                {
                    Id = a.AccountId,
                    Role = a.Roles,
                    Email = a.Email,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                     Phone= a.Phone
                })
                .FirstOrDefaultAsync();
            if (result is null)
            {
                throw new NotFoundException($"nie znaleziono produktu o id {id}");
            }
            return result;
    }
}