using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Hiraya.MultiTenancy.Dto;

namespace Hiraya.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

