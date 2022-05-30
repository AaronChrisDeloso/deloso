using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace deloso.EntityFrameworkCore
{
    public static class delosoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<delosoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<delosoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
