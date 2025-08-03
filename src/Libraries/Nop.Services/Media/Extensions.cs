using Nop.Core.Domain.Media;
using Nop.Core.Infrastructure;

namespace Nop.Services.Media;

/// <summary>
/// Extensions
/// </summary>
public static partial class Extensions
{
    public static string GetLocalPicturesPath(this INopFileProvider fileProvider, MediaSettings mediaSettings, string path = null)
    {
        if (string.IsNullOrEmpty(path))
        {
            var imagePath = mediaSettings.PicturePath;

            path = string.IsNullOrEmpty(imagePath) ? NopMediaDefaults.DefaultImagesPath : imagePath;
        }

        if (!Path.IsPathRooted(path))
            path = fileProvider.GetAbsolutePath(path);

        return path;
    }
}