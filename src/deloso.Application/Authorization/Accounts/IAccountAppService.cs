using System.Threading.Tasks;
using Abp.Application.Services;
using deloso.Authorization.Accounts.Dto;

namespace deloso.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
