using CSharpFunctionalExtensions;
using ProductivityServices.ViewModels;
using System;

namespace ProductivityServices.Factory.Factory
{
    public class FactoryViewModel : BaseViewModel
    {
        public Factory Factory { get; set; }

        private IFactoryService _factoryService;

        public FactoryViewModel(IFactoryService factoryService)
        {
            _factoryService = factoryService ?? throw new ArgumentNullException(nameof(factoryService));
            Factory = new Factory();
        }

        public RelayCommand SaveCommand => new RelayCommand(OnSave);

        private void OnSave(object obj)
        {
           Result result= _factoryService.Save();
        }

        public RelayCommand OpenCommand => new RelayCommand(OnOpen);

        private void OnOpen(object obj)
        {
            Result result= _factoryService.Load();
        }
    }
}
