using Abp.Modules;
using Abp.Reflection.Extensions;
using System;

namespace Hiraya.MongoDb
{
    [DependsOn(
        typeof(HirayaCoreModule))]
    public class HirayaMongoDbModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HirayaMongoDbModule).GetAssembly());
        }
    }
}
