
namespace kurs.Models.ViewModels;

public class StartPageViewModel
{
    public string? Title { get; set; }

    public string? Body { get; set; }

    public IEnumerable<IContent>? Children { get; set; }
}
