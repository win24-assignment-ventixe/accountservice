using Microsoft.AspNetCore.Identity;

namespace Data.Interfaces;

public interface IAccountRepository : IBaseRepository<IdentityUser>
{
}