using EPiServer.Framework.DataAnnotations;

namespace kurs.Models.Assets
{
    [ContentType(
        DisplayName = "ImageFile", 
        GUID = "A6F4054A-29AC-431D-8088-26D3F1966DDF", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
    }
}
