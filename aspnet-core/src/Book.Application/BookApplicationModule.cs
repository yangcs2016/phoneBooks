using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Book.Authorization;

namespace Book
{
    [DependsOn(
        typeof(BookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BookAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BookApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
