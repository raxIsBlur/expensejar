using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using expensejar.Authorization.Roles;
using expensejar.Authorization.Users;
using expensejar.MultiTenancy;
using expensejar.Budgets;
using expensejar.Categories;
using expensejar.PaymentMethods;
using expensejar.Transactions;

namespace expensejar.EntityFrameworkCore
{
    public class expensejarDbContext : AbpZeroDbContext<Tenant, Role, User, expensejarDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<BudgetItem> Budgets { get; set; }
        public virtual DbSet<BudgetItem> BudgetItems { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }

        public expensejarDbContext(DbContextOptions<expensejarDbContext> options)
            : base(options)
        {
        }
    }
}
