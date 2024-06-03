namespace cwiczenia10.ResponseModels;

public class GetAccountResponseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
}