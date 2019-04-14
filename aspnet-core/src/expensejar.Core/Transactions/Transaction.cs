using Abp.Domain.Entities.Auditing;
using expensejar.Categories;
using expensejar.Constants;
using expensejar.PaymentMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace expensejar.Transactions
{
    public class Transaction : FullAuditedEntity
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        public double Amount { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public int? SubCategoryId { get; set; }

        [ForeignKey(nameof(SubCategoryId))]
        public SubCategory SubCategory { get; set; }

        public int? PaymentMethodId { get; set; }

        [ForeignKey(nameof(PaymentMethodId))]
        public PaymentMethod PaymentMethod { get; set; }

        public DateTime TransactionDate { get; set; }

        [StringLength(EntityStringLengths.RemarksLength)]
        public string Remarks { get; set; }
    }
}
