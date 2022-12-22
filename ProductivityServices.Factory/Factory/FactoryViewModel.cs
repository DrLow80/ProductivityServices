using ProductivityServices.ViewModels;
using System;

namespace ProductivityServices.Factory.Factory
{
    public class FactoryViewModel : BaseViewModel
    {
        public Factory Factory { get; set; }

        private IFileSystemService _fileSystemService;

        public FactoryViewModel(IFileSystemService fileSystemService)
        {
            _fileSystemService = fileSystemService ?? throw new ArgumentNullException(nameof(fileSystemService));
            Factory = new Factory();
        }

        public RelayCommand SaveCommand => new RelayCommand(OnSave);

        private void OnSave(object obj)
        {
            _fileSystemService.Save(Factory);
        }

        public RelayCommand OpenCommand => new RelayCommand(OnOpen);

        private void OnOpen(object obj)
        {
            Factory = _fileSystemService.Load().Value;
        }
    }
}
