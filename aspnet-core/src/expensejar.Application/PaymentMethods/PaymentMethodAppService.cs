using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using expensejar.PaymentMethods.Dtos;

namespace expensejar.PaymentMethods
{
    public class PaymentMethodAppService : expensejarAppServiceBase, IPaymentMethodAppService
    {
        private readonly IPaymentMethodManager _paymentMethodManager;

        public PaymentMethodAppService(IPaymentMethodManager paymentMethodManager)
        {
            _paymentMethodManager = paymentMethodManager;
        }

        public async Task CreateOrUpdateAsync(PaymentMethodDto input)
        {
            await _paymentMethodManager.CreateOrUpdateAsync(input.MapTo<PaymentMethod>());
        }

        public async Task DeleteAsync(EntityDto input)
        {
            await _paymentMethodManager.DeleteAsync(input.Id);
        }

        public async Task<ICollection<PaymentMethodDto>> GetAllPaymentMethodsAsync()
        {
            return (await _paymentMethodManager.GetAllAsync(null)).MapTo<List<PaymentMethodDto>>();
        }

        public async Task<PaymentMethodDto> GetPaymentMethodDetailAsync(EntityDto input)
        {
            return (await _paymentMethodManager.GetAsync(input.Id)).MapTo<PaymentMethodDto>();
        }
    }
}
