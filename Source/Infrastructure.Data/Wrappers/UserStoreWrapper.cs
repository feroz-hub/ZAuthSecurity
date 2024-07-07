using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Data.Wrappers;

public class UserStoreWrapper(ApplicationDbContext context) : UserStore<Users, Roles, ApplicationDbContext, Guid, UserClaims, UserRoles, UserLogins, UserTokens, RoleClaims>(context);