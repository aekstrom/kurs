using EPiServer.ServiceLocation;
using kurs.Models.Pages;
using kurs.Models.ViewModels;

namespace kurs.Factories;

public interface IStartPageViewModelFactory 
{
    StartPageViewModel CreateViewModel(StartPage page);
}

[ServiceConfiguration(typeof(IStartPageViewModelFactory), Lifecycle = ServiceInstanceScope.Scoped)]
public class StartPageViewModelFactory : IStartPageViewModelFactory
{
    private readonly IContentLoader contentLoader;

    public StartPageViewModelFactory(IContentLoader contentLoader)
    {
        this.contentLoader = contentLoader;
    }

    public StartPageViewModel CreateViewModel(StartPage page)
    {
        return new StartPageViewModel
        {
            Children = contentLoader.GetChildren<IContent>(page.ContentLink),
            Body = page.Body,
            Title = page.Title
        };
    }
}
