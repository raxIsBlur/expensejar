using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using expensejar.Authorization.Roles;
using expensejar.Authorization.Users;
using expensejar.MultiTenancy;

namespace expensejar.EntityFrameworkCore
{
    public class expensejarDbContext : AbpZeroDbContext<Tenant, Role, User, expensejarDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public expensejarDbContext(DbContextOptions<expensejarDbContext> options)
            : base(options)
        {
        }
    }
}
