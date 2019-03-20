using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Book.Controllers
{
    public abstract class BookControllerBase: AbpController
    {
        protected BookControllerBase()
        {
            LocalizationSourceName = BookConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
