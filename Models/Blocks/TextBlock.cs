using System.ComponentModel.DataAnnotations;

namespace kurs.Models.Blocks;

[ContentType(
    DisplayName = "Text block",
    GUID = "0027EA98-11C9-4B20-9B06-C9B51CB0B287",
    Description = "")]
public class TextBlock : BlockData
{
    [CultureSpecific]
    [Display(
        Name = "Text",
        Description = "Text for this block")]
    public virtual XhtmlString? HtmlText { get; set; }
}
