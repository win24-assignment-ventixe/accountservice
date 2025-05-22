using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class AccountRepository(DataContext context) : BaseRepository<AccountEntity>(context), IAccountRepository
{
}