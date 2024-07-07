using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Data.Wrappers;

public class RoleStoreWrapper(ApplicationDbContext context)
    : RoleStore<Roles, ApplicationDbContext, Guid, UserRoles, RoleClaims>(context);