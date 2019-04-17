using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace expensejar.Budgets.Dtos
{
    [AutoMapFrom(typeof(BudgetItem))]
    [AutoMapTo(typeof(BudgetItem))]
    public class BudgetDto : EntityDto
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        [StringLength(EntityStringLengths.DescriptionLength)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<BudgetItemDto> BudgetItems { get; set; }
    }
}
