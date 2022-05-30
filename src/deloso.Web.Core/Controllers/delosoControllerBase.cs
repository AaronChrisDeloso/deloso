using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace deloso.Controllers
{
    public abstract class delosoControllerBase: AbpController
    {
        protected delosoControllerBase()
        {
            LocalizationSourceName = delosoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
