using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Hiraya.Configuration;
using Hiraya.Web;

namespace Hiraya.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HirayaDbContextFactory : IDesignTimeDbContextFactory<HirayaDbContext>
    {
        public HirayaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HirayaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HirayaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HirayaConsts.ConnectionStringName));

            return new HirayaDbContext(builder.Options);
        }
    }
}
