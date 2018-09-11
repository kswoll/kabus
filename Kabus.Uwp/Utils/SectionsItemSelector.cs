using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Kabus.Uwp.ViewModels;

namespace Kabus.Uwp.Utils
{
    public class SectionsItemSelector : DataTemplateSelector
    {
        public DataTemplate SectionTemplate { get; set; }
        public DataTemplate FolderTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
//            if (item is SectionViewModel)
//                return SectionTemplate;
//            else
                return FolderTemplate;
        }
    }
}