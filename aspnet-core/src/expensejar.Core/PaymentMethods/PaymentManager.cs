using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.PaymentMethods
{
    class PaymentManager : IPaymentManager
    {
        public Task CreateAsync(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethod> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PaymentMethod paymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
