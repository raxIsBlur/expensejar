﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace expensejar.PaymentMethods.Dtos
{
    [AutoMapFrom(typeof(PaymentMethod))]
    [AutoMapTo(typeof(PaymentMethod))]
    public class PaymentMethodDto : EntityDto
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        [StringLength(EntityStringLengths.DescriptionLength)]
        public string Description { get; set; }

        public PaymentMethodType Type { get; set; }
    }
}
