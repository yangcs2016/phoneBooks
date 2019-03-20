using Microsoft.AspNetCore.Antiforgery;
using Book.Controllers;

namespace Book.Web.Host.Controllers
{
    public class AntiForgeryController : BookControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
