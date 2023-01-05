using ProductivityServices.Foundation.Models;
using ProductivityServices.ViewModels;

namespace ProductivityServices.Feature.Workcenters
{
    public class WorkCenterViewModel : BaseViewModel
    {
        public WorkCenter WorkCenter { get; set; }

        public WorkCenterViewModel(WorkCenter workcenter)
        {
            WorkCenter = workcenter;
        }

    }
}
