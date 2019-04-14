using Abp.Application.Services;
using Abp.Application.Services.Dto;
using expensejar.MultiTenancy.Dto;

namespace expensejar.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

