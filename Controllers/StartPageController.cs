using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using kurs.Factories;
using kurs.Models.Pages;
using kurs.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace kurs.Controllers;

[TemplateDescriptor(Inherited = true)]
public class StartPageController : PageController<StartPage>
{
    private readonly IStartPageViewModelFactory startPageViewModelFactory;

    public StartPageController(IStartPageViewModelFactory startPageViewModelFactory)
    {
        this.startPageViewModelFactory = startPageViewModelFactory;
    }

    public ActionResult Index(StartPage currentPage)
    {
        var viewModel = startPageViewModelFactory.CreateViewModel(currentPage);
        return View(viewModel);
    }
}


//private readonly IStartPageViewModelFactory startPageViewModelFactory;



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



