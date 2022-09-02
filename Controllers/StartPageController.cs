using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using kurs.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace kurs.Controllers;

[TemplateDescriptor(Inherited = true)]
public class StartPageController : PageController<StartPage>
{
    public ActionResult Index(StartPage currentPage)
    {
        return View(currentPage);
    }
}


//private readonly IStartPageViewModelFactory startPageViewModelFactory;

////private readonly IContentLoader contentLoader;

//public StartPageController(IContentLoader contentLoader)
//{
//    this.contentLoader = contentLoader;
//}

//public StartPageController(IStartPageViewModelFactory startPageViewModelFactory)
//{
//    this.startPageViewModelFactory = startPageViewModelFactory;
//}


//public ActionResult Index(StartPage currentPage)
//{
//    var viewModel = startPageViewModelFactory.CreateViewModel(currentPage);

//    //return View(viewModel);
//    //return View(CreateViewModel(currentPage));
//    return View(currentPage);
//}


//private StartPageViewModel CreateViewModel(StartPage page)
//{
//    return new StartPageViewModel
//    {
//        Children = contentLoader.GetChildren<IContent>(page.ContentLink),
//        MyProperty = page.MyProperty
//    };
//}
