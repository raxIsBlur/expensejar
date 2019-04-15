using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.PaymentMethods
{
    public class PaymentMethodAppService : expensejarAppServiceBase, IPaymentMethodAppService
    {
        private readonly IPaymentManager _paymentManager;

        public PaymentMethodAppService(IPaymentManager paymentManager)
        {
            _paymentManager = paymentManager;
        }
    }
}
