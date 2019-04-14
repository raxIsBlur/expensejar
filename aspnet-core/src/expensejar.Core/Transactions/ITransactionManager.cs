using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Transactions
{
    public interface ITransactionManager : IDomainService
    {
        Task<Transaction> GetAsync(long id);

        Task<ICollection<Transaction>> GetAllUserTransactionsAsync(int id);

        Task CreateAsync(Transaction transaction);

        Task UpdateAsync(Transaction transaction);

        Task DeleteAsync(long id);
    }
}
