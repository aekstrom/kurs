using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace kurs.Models.Blocks;

[ContentType(
    DisplayName = "Image block",
    GUID = "6EB5DEE7-9AEA-4184-8904-8C6F55241439",
    Description = "")]
public class ImageBlock : BlockData
{
    [Display(
        Name = "Image",
        Description = "Image block")]
    [UIHint(UIHint.Image)]
    public virtual ContentReference Image { get; set; }
}
