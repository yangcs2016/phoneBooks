using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Book.Controllers;

namespace Book.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
