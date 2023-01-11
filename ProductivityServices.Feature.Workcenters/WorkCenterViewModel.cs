using ProductivityServices.Foundation.Models;
using ProductivityServices.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProductivityServices.Feature.Workcenters
{
    public class WorkCenterViewModel : BaseViewModel
    {
        public WorkCenter WorkCenter { get; set; }

        public WorkCenterViewModel(WorkCenter workcenter)
        {
            WorkCenter = workcenter;
            Stations = new ObservableCollection<Station>();

            foreach (var station in workcenter.Stations)
            {
                Stations.Add(station);
            }
        }

        public ObservableCollection<Station> Stations { get; set; }

        public RelayCommand AddStationCommand => new RelayCommand(OnAddStation);

        private void OnAddStation(object obj)
        {
            Station station = new Station();

            WorkCenter.Stations = WorkCenter.Stations.Append(station);

            Stations.Add(station);
        }
    }
}
