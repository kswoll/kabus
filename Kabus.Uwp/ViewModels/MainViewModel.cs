using System.Collections.Generic;

namespace Kabus.Uwp.ViewModels
{
    public class MainViewModel
    {
        public List<FolderViewModel> Sections { get; set; } = new List<FolderViewModel>();

        public MainViewModel()
        {
            Sections.Add(new FolderViewModel
            {
                Name = "Inbox"
            });
            Sections.Add(new FolderViewModel
            {
                Name = "Test",
                Items =
                {
                    new FolderViewModel
                    {
                        Name = "Folder"
                    }
                }
            });
        }
    }
}