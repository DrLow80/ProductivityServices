using CSharpFunctionalExtensions;
using ProductivityServices.Foundation.Models;
using ProductivityServices.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProductivityServices.Feature.Workcenters
{
    public class ListViewModel : BaseViewModel
    {
        private readonly IModelsService _modelsService;

        public ListViewModel(IModelsService modelsService)
        {
            _modelsService = modelsService ?? throw new ArgumentNullException(nameof(modelsService));

            WorkCenterViewModels = new ObservableCollection<WorkCenterViewModel>();
        }

        public ObservableCollection<WorkCenterViewModel> WorkCenterViewModels { get; set; }

        public RelayCommand LoadCommand => new RelayCommand(OnLoad);

        private void OnLoad(object obj)
        {
            _modelsService.ListWorkCenters().ToResult("FAIL").Tap(LoadWorkcenterViewModels);
        }

        private void LoadWorkcenterViewModels(IEnumerable<WorkCenter> workcenters)
        {
            WorkCenterViewModels.Clear();

            foreach (var workcenter in workcenters)
            {
                WorkCenterViewModel workCenterViewModel = new(workcenter);

                WorkCenterViewModels.Add(workCenterViewModel);
            }
        }

        public WorkCenterViewModel SelectedWorkCenterViewModel { get; set; }
    }
}
