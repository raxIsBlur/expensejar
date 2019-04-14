using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace expensejar.EntityFrameworkCore
{
    public static class expensejarDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<expensejarDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<expensejarDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
