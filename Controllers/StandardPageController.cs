using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using kurs.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace kurs.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class StandardPageController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}
