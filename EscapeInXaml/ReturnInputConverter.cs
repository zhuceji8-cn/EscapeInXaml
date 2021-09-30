using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace EscapeInXaml
{
    public class ReturnInputConverter : MarkupExtension, IValueConverter
    {
        public string Input { get; set; } = string.Empty;

        public override object ProvideValue(IServiceProvider serviceProvider) => this;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => Input;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => Binding.DoNothing;
    }
}