using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace deloso.Web.Views
{
    public abstract class delosoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected delosoRazorPage()
        {
            LocalizationSourceName = delosoConsts.LocalizationSourceName;
        }
    }
}
