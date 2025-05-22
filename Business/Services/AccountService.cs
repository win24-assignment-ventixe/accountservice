using Business.Interfaces;
using Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Business.Services;

public class AccountService(IAccountRepository accountRepository, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager) : IAccountService
{
    private readonly IAccountRepository _accountRepository = accountRepository;
    private readonly UserManager<IdentityUser> _userManager = userManager;
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;
}
