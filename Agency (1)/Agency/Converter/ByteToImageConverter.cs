using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Agency
{
    public class ByteToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
     System.Globalization.CultureInfo culture)
        {
            using (var ms = new System.IO.MemoryStream((Byte[])value))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad; // here
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter,
        System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
