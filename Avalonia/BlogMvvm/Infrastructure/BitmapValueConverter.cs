using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Avalonia.Media.Imaging;
using Avalonia.Data.Converters;
using BlogMvvm.Models;

namespace BlogMvvm.Infrastructure;

public class BitmapValueConverter : IValueConverter
{
    public static BitmapValueConverter Instance = new BitmapValueConverter();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string && targetType == typeof(Bitmap))
        {
            //var uri = new Uri((string)value, UriKind.RelativeOrAbsolute);

            // var scheme = uri.IsAbsoluteUri ? uri.Scheme : "file";

            // switch (scheme)
            // {
            //     case "file":
            //         return new Bitmap((string)value);

            //     default:
            //         var assets = AvaloniaLocator.Current.GetService<IAssetLoader>();
            //         return new Bitmap(assets.Open(uri));
            // }
            var resourceName = $"BlogMvvm.Assets.{value}.png";
            return new Bitmap(
                typeof(BlogEntity)
                .GetTypeInfo()
                .Assembly.GetManifestResourceStream(resourceName));
        }
        throw new NotSupportedException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}