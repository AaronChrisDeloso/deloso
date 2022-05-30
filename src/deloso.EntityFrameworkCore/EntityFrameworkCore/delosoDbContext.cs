using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using deloso.Authorization.Roles;
using deloso.Authorization.Users;
using deloso.MultiTenancy;

namespace deloso.EntityFrameworkCore
{
    public class delosoDbContext : AbpZeroDbContext<Tenant, Role, User, delosoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public delosoDbContext(DbContextOptions<delosoDbContext> options)
            : base(options)
        {
        }
    }
}
