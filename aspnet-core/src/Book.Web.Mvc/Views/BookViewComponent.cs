using Abp.AspNetCore.Mvc.ViewComponents;

namespace Book.Web.Views
{
    public abstract class BookViewComponent : AbpViewComponent
    {
        protected BookViewComponent()
        {
            LocalizationSourceName = BookConsts.LocalizationSourceName;
        }
    }
}
