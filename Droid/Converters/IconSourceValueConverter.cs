using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Converters
{
	public class IconSourceValueConverter : MvxValueConverter<string, string>
	{
		protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
            string retval = string.Format("res:{0}", value.ToLower()).Replace(".png", "");
			return retval;
		}
	}
}
