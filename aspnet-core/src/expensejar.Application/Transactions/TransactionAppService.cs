using Abp.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
