using Microsoft.AspNetCore.Identity;

namespace Data.Entities;

public class AccountEntity : IdentityUser
{
    [ProtectedPersonalData]
    public string? FirstName { get; set; }
    [ProtectedPersonalData]
    public string? LastName { get; set; }
}