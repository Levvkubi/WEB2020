// <copyright file="PriorityColor.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaskAssistant
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    class PriorityColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case 1:
                    return "#FD699A";
                case 2:
                    return "#9677FF";
                case 3:
                    return "#5BB1FF";
                default:
                    return "#5BB1FF";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 3;
        }
    }
}
