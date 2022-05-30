using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using deloso.EntityFrameworkCore;
using deloso.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace deloso.Web.Tests
{
    [DependsOn(
        typeof(delosoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class delosoWebTestModule : AbpModule
    {
        public delosoWebTestModule(delosoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(delosoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(delosoWebMvcModule).Assembly);
        }
    }
}