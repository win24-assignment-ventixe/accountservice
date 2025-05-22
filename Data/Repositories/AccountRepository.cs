using Data.Contexts;
using Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Data.Repositories;

public class AccountRepository(DataContext context) : BaseRepository<IdentityUser>(context), IAccountRepository
{
}