using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using expensejar.Configuration;
using expensejar.Web;

namespace expensejar.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class expensejarDbContextFactory : IDesignTimeDbContextFactory<expensejarDbContext>
    {
        public expensejarDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<expensejarDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            expensejarDbContextConfigurer.Configure(builder, configuration.GetConnectionString(expensejarConsts.ConnectionStringName));

            return new expensejarDbContext(builder.Options);
        }
    }
}
