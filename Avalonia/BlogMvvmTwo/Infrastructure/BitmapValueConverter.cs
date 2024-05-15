using System;
using System.Globalization;
using System.Reflection;
using Avalonia.Media.Imaging;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Platform;

namespace BlogMvvmTwo.Infrastructure;

public class BitmapValueConverter : IValueConverter
{
    public static BitmapValueConverter Instance = new BitmapValueConverter();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string imagePath && targetType == typeof(IImage))
        {
            try
            {
                var prefix = $"avares://{Assembly.GetExecutingAssembly().GetName().Name}/Assets/";
                var uri = new Uri(prefix + imagePath, UriKind.RelativeOrAbsolute);
                var bitmap = new Bitmap(AssetLoader.Open(uri));
                return bitmap;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        throw new NotSupportedException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}