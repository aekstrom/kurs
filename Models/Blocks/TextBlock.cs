using System.ComponentModel.DataAnnotations;

namespace kurs.Models.Blocks;

[ContentType(
    DisplayName = "Text block",
    GUID = "0027EA98-11C9-4B20-9B06-C9B51CB0B287",
    Description = "")]
public class TextBlock : BlockData
{

    [Display(
        Name = "Text",
        Description = "Text for this block")]
    [StringLength(10)]
    [Required]
    public virtual string Text { get; set; }
}
