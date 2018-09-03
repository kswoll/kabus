using System.Collections.Generic;

namespace Kabus.Uwp.ViewModels
{
    public class SectionViewModel
    {
        public string Name { get; set; }
        public List<FolderViewModel> Items { get; set; } = new List<FolderViewModel>();
    }
}