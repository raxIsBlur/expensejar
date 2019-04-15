using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Session;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Transactions
{
    public class TransactionManager : DomainService, ITransactionManager
    {
        private readonly IRepository<Transaction, int> _transactionRepository;
        private readonly IAbpSession _abpSession;

        public TransactionManager(
            IRepository<Transaction, int> transactionRepository, IAbpSession abpSession)
        {
            _transactionRepository = transactionRepository;
            _abpSession = abpSession;
        }

        public async Task CreateOrUpdateAsync(Transaction transaction)
        {
            await _transactionRepository.InsertOrUpdateAsync(transaction);
        }

        public async Task DeleteAsync(int id)
        {
            await _transactionRepository.DeleteAsync(id);
        }

        public async Task<ICollection<Transaction>> GetAllUserTransactionsAsync(int id)
        {
            return await _transactionRepository.GetAll().Where(x => x.CreatorUserId == _abpSession.UserId).ToListAsync();
        }

        public async Task<Transaction> GetAsync(int id)
        {
            return await _transactionRepository.GetAsync(id);
        }
    }
}
