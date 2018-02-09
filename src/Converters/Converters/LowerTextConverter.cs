﻿using System;
using Xamarin.Forms;
using System.Globalization;

namespace XamarinCommunityToolkit.Converters
{
    [ValueConversion (typeof (string), typeof (string))]
    public class LowerTextConverter : IValueConverter
    {
        public static LowerTextConverter Instance { get; } = new LowerTextConverter();


        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var text = ((string)value);

            return text.ToLowerInvariant();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

