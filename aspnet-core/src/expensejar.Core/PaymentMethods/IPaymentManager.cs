using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.PaymentMethods
{
    public interface IPaymentManager : IDomainService
    {
        Task<PaymentMethod> GetAsync(int id);

        Task CreateOrUpdateAsync(PaymentMethod paymentMethod);

        Task DeleteAsync(int id);
    }
}
