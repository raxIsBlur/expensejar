using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Transactions.Dtos
{
    public class GetAllTransactionInput
    {
        public string Name { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public string PaymentMethodName { get; set; }

        public string CategoryName { get; set; }

        public string SubCategoryName { get; set; }

        public double? MinimumAmount { get; set; }

        public double? MaximumAmount { get; set; }

    }
}
