using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Sms.Forms.Converters
{
    /// <summary>
    /// Byte array to ImageSource
    /// </summary>
    public class ByteArrayToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //Кеширование пока не добавлял!!!
            if (value == null || !(value is byte[])) return null;

            MemoryStream stream = new MemoryStream((byte[])value);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            
            throw new NotImplementedException();
        }
    }
}
