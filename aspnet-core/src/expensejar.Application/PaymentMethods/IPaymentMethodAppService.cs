using Abp.Application.Services;
using Abp.Application.Services.Dto;
using expensejar.PaymentMethods.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.PaymentMethods
{
    public interface IPaymentMethodAppService : IApplicationService
    {
        Task<PaymentMethodDto> GetTransactionDetailAsync(EntityDto input);

        Task<ICollection<PaymentMethodDto>> GetAllPaymentMethods();

        Task CreateOrUpdateAsync(PaymentMethodDto input);

        Task DeleteAsync(EntityDto input);
    }
}
