using System.Windows.Input;

namespace ProductivityServices.ViewModels
{
    public abstract class BaseHostViewModel : BaseViewModel
    {
        public BaseViewModel CurrentViewModel { get; set; }

        public ICommand NavigateCommand => new RelayCommand<BaseViewModel>(OnNavigate);

        private void OnNavigate(BaseViewModel obj)
        {
            CurrentViewModel = obj;
        }
    }
}
