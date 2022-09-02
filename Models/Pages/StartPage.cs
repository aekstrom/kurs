using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace kurs.Models.Pages;

[ContentType(
    DisplayName = "StartPage",
    GUID = "CA23B828-3155-403C-B6EB-A19E38B7A368",
    Description = "My start page")]
public class StartPage : PageData
{
    [CultureSpecific]
    [Display(
        Name = "Title",
        Description = "My title description",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string? Title { get; set; }

    [CultureSpecific]
    [Display(
        Name = "Body",
        Description = "My body description",
        GroupName = SystemTabNames.Content,
        Order = 20)]
    [UIHint(UIHint.Textarea)]
    public virtual string? Body { get; set; }

    //[CultureSpecific]
    //[Display(
    //   Name = "Sida",
    //   Description = "My property description",
    //   GroupName = SystemTabNames.Content,
    //   Order = 30)]
    //public virtual ContentReference? PageReference { get; set; }
}
