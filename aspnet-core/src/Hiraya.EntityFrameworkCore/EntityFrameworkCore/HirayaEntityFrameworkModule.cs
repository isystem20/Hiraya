using Abp.Dependency;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Hiraya.EntityFrameworkCore.Seed;
using Microsoft.EntityFrameworkCore;

namespace Hiraya.EntityFrameworkCore
{
    [DependsOn(
        typeof(HirayaCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class HirayaEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<HirayaDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        HirayaDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        HirayaDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HirayaEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            using (var scope = IocManager.CreateScope())
            {
                var dbContextResolver = scope.Resolve<IDbContextResolver>();
                dbContextResolver.Resolve<HirayaDbContext>(Configuration.DefaultNameOrConnectionString, null)
                    .Database.Migrate();
            }

            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
