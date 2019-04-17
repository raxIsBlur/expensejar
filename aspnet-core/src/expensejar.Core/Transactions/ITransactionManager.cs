using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Transactions
{
    public interface ITransactionManager : IDomainService
    {
        Task<Transaction> GetAsync(int id);

        Task<ICollection<Transaction>> GetAllUserTransactionsAsync();

        Task CreateOrUpdateAsync(Transaction transaction);

        Task DeleteAsync(int id);
    }
}
