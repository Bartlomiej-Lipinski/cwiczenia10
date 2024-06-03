using cwiczenia10.ResponseModels;

namespace cwiczenia10.Services;

public interface IAccountService
{
    Task<GetAccountResponseModel> GetAccountByIdAsync(int id);
}