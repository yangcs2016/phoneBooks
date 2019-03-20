using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Book.Web.Views
{
    public abstract class BookRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BookRazorPage()
        {
            LocalizationSourceName = BookConsts.LocalizationSourceName;
        }
    }
}
