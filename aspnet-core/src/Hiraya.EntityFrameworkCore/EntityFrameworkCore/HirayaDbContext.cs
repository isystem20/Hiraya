using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Hiraya.Authorization.Roles;
using Hiraya.Authorization.Users;
using Hiraya.MultiTenancy;

namespace Hiraya.EntityFrameworkCore
{
    public class HirayaDbContext : AbpZeroDbContext<Tenant, Role, User, HirayaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HirayaDbContext(DbContextOptions<HirayaDbContext> options)
            : base(options)
        {
        }
    }
}
