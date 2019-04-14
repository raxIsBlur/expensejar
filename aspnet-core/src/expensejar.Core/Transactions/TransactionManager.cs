using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Transactions
{
    class TransactionManager : ITransactionManager
    {
        public Task CreateAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Transaction>> GetAllUserTransactionsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
