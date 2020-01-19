using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Hiraya.EntityFrameworkCore
{
    public static class HirayaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HirayaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HirayaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
