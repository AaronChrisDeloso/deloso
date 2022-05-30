using Abp.AspNetCore.Mvc.ViewComponents;

namespace deloso.Web.Views
{
    public abstract class delosoViewComponent : AbpViewComponent
    {
        protected delosoViewComponent()
        {
            LocalizationSourceName = delosoConsts.LocalizationSourceName;
        }
    }
}
