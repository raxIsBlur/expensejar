using Microsoft.AspNetCore.Antiforgery;
using expensejar.Controllers;

namespace expensejar.Web.Host.Controllers
{
    public class AntiForgeryController : expensejarControllerBase
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
