using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using expensejar.Transactions.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Transactions
{
    [AbpAuthorize]
    public class TransactionAppService : expensejarAppServiceBase, ITransactionAppService
    {
        private readonly ITransactionManager _transactionManager;

        public TransactionAppService(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }

        public async Task CreateOrUpdateAsync(TransactionDto input)
        {
            await _transactionManager.CreateOrUpdateAsync(input.MapTo<Transaction>());
        }

        public async Task DeleteAsync(EntityDto input)
        {
            await _transactionManager.DeleteAsync(input.Id);
        }

        public async Task<ICollection<TransactionDto>> GetAllTransactions(GetAllTransactionInput input)
        {
            return (await _transactionManager.GetAllUserTransactionsAsync()).MapTo<List<TransactionDto>>();
        }

        public async Task<TransactionDto> GetTransactionDetailAsync(EntityDto input)
        {
            return (await _transactionManager.GetAsync(input.Id)).MapTo<TransactionDto>();
        }
    }
}
