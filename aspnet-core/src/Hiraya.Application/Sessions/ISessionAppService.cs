using System.Threading.Tasks;
using Abp.Application.Services;
using Hiraya.Sessions.Dto;

namespace Hiraya.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
