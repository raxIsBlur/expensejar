﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace expensejar.Transactions.Dtos
{
    [AutoMapFrom(typeof(Transaction))]
    [AutoMapTo(typeof(Transaction))]
    public class TransactionDto : EntityDto
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        public double Amount { get; set; }

        public int CategoryId { get; set; }

        public int? SubCategoryId { get; set; }

        public int? PaymentMethodId { get; set; }

        public DateTime TransactionDate { get; set; }

        [StringLength(EntityStringLengths.RemarksLength)]
        public string Remarks { get; set; }
    }
}
