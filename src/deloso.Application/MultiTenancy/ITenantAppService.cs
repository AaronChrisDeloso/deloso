using Abp.Application.Services;
using deloso.MultiTenancy.Dto;

namespace deloso.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

