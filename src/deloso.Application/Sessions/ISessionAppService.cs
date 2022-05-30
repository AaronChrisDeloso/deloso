using System.Threading.Tasks;
using Abp.Application.Services;
using deloso.Sessions.Dto;

namespace deloso.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
