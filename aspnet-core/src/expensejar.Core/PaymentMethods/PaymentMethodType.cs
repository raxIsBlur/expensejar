using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.PaymentMethods
{
    public enum PaymentMethodType
    {
        Cash,
        BankTransfer,
        CreditCard,
        DebitCard,
        OnlineTransfer // this needs to be defined better
    }
}
