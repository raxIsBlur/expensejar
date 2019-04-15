using Abp.Application.Services;
using Abp.Application.Services.Dto;
using expensejar.Transactions.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Transactions
{
    public interface ITransactionAppService : IApplicationService
    {
        Task<TransactionDto> GetTransactionDetailAsync(EntityDto input);

        Task<ICollection<TransactionDto>> GetAllTransactions(GetAllTransactionInput input);

        Task CreateOrUpdateAsync(TransactionDto input);

        Task DeleteAsync(EntityDto input);
    }
}
