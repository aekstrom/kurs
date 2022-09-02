using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace kurs.Models.Pages;

[ContentType(
    DisplayName = "StandardPage",
    GUID = "7C4FA4C9-118F-430B-A55D-529924310115",
    Description = "My standard page")]
public class StandardPage : PageData
{
    [CultureSpecific]
    [Display(
        Name = "Title",
        Description = "My property description",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string? Title { get; set; }

    [Display(
            Name = "Content Area",
            Description = "My property description",
            GroupName = SystemTabNames.Content,
            Order = 20)]
    public virtual ContentArea? Area { get; set; }
}
