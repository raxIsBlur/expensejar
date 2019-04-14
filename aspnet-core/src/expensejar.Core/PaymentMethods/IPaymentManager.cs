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

        Task CreateAsync(PaymentMethod paymentMethod);

        Task UpdateAsync(PaymentMethod paymentMethod);

        Task DeleteAsync(int id);
    }
}
