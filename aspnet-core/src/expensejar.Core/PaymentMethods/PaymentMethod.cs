using Abp.Domain.Entities.Auditing;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace expensejar.PaymentMethods
{
    public class PaymentMethod : AuditedEntity
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        [StringLength(EntityStringLengths.DescriptionLength)]
        public string Description { get; set;  }

        public PaymentMethodType Type { get; set; }
    }
}
