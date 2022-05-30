using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using deloso.Controllers;

namespace deloso.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : delosoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
