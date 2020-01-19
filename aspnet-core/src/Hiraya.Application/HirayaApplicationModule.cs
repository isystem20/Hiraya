using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Hiraya.Authorization;
using Hiraya.MongoDb;

namespace Hiraya
{
    [DependsOn(
        typeof(HirayaCoreModule), 
        typeof(HirayaMongoDbModule), 
        typeof(AbpAutoMapperModule))]
    public class HirayaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HirayaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HirayaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
