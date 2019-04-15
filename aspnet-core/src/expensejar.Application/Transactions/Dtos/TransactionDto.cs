using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Transactions.Dtos
{
    [AutoMapFrom(typeof(Transaction))]
    [AutoMapTo(typeof(Transaction))]
    public class TransactionDto : EntityDto
    {
        public string Name { get; set; }

        public double Amount { get; set; }

        public int CategoryId { get; set; }

        public int? SubCategoryId { get; set; }

        public int? PaymentMethodId { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Remarks { get; set; }
    }
}
