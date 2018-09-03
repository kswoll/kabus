using System.Collections.Generic;

namespace Kabus.Uwp.ViewModels
{
    public class MainViewModel
    {
        public List<SectionViewModel> Sections { get; set; } = new List<SectionViewModel>();

        public MainViewModel()
        {
            Sections.Add(new SectionViewModel
            {
                Name = "Inbox"
            });
        }
    }
}