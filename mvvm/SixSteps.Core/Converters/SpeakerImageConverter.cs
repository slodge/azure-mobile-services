using System;
using Cirrious.MvvmCross.Converters;

namespace SixSteps.Core.Converters
{
    public class SpeakerImageConverter
        : MvxBaseValueConverter
    {
        public const string BaseUri = "http://elastastorage.blob.core.windows.net/eventphotos/";

        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var speaker = value as string;
            if (speaker == null)
            {
                return null;
            }

            var filePath = !speaker.Contains(BaseUri) ? String.Concat(BaseUri, speaker) : speaker;
            return filePath;
        }
    }
}