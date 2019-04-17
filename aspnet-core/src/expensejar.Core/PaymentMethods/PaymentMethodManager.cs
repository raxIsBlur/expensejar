using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Session;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.PaymentMethods
{
    public class PaymentMethodManager : DomainService, IPaymentMethodManager
    {
        private readonly IRepository<PaymentMethod, int> _paymentMethodRepository;
        private readonly IAbpSession _abpSession;

        public PaymentMethodManager(IRepository<PaymentMethod, int> paymentMethodRepository, IAbpSession abpSession)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _abpSession = abpSession;
        }

        public async Task CreateOrUpdateAsync(PaymentMethod paymentMethod)
        {
            await _paymentMethodRepository.InsertOrUpdateAsync(paymentMethod);
        }

        public async Task DeleteAsync(int id)
        {
            await _paymentMethodRepository.DeleteAsync(id);
        }

        public async Task<ICollection<PaymentMethod>> GetAllAsync(int? id)
        {
            return await _paymentMethodRepository.GetAll().ToListAsync();
        }

        public async Task<PaymentMethod> GetAsync(int id)
        {
            return await _paymentMethodRepository.GetAsync(id);
        }
    }
}
