using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using deloso.Authorization;

namespace deloso
{
    [DependsOn(
        typeof(delosoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class delosoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<delosoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(delosoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
