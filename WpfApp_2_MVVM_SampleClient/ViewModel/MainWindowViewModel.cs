using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfApp_2_MVVM_SampleClient.Infrastructure;

namespace WpfApp_2_MVVM_SampleClient.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        Client _currentClient;
        public Client CurrentClient
        {
            get
            {
                if (_currentClient == null)
                    _currentClient = new Client();
                return _currentClient;
            }
            set
            {
                _currentClient = value;
                OnPropertyChanged("CurrentClient");
            }
        }

        ObservableCollection<Client> _clients;
        public ObservableCollection<Client> Clients
        {
            get
            {
                if (_clients == null)
                    _clients = ClientRepository.AllClients;
                return _clients;
            }
        }

        private ICommand _closeLoginForm;
        public ICommand CloseLoginForm
        {
            get
            {
                if (_closeLoginForm == null)
                    _closeLoginForm = new RelayCommand(ExecuteCloseLoginForm);
                return _closeLoginForm;
            }
        }

        private void ExecuteCloseLoginForm(object obj)
        {
            Application.Current.Shutdown();
        }

        private ICommand _logInClientCommand;
        public ICommand LogInClient
        {
            get
            {
                if (_logInClientCommand == null)
                    _logInClientCommand = new RelayCommand(ExecuteAddClientCommand, CanExecuteAddClientCommand);
                return _logInClientCommand;
            }
        }


        public void ExecuteAddClientCommand(object parameter)
        {

            var cu = Clients.FirstOrDefault(c => c.FirstName == CurrentClient.FirstName && c.Password == CurrentClient.Password);
            
            if (cu != null)
            {
                MessageBox.Show($"You enter as {CurrentClient.FirstName}");
            }
            else
            {
                MessageBox.Show("Wrong Login or Password");
            }
            CurrentClient = null;
        }

        public bool CanExecuteAddClientCommand(object parameter)
        {
            if (string.IsNullOrEmpty(CurrentClient.FirstName) ||
                string.IsNullOrEmpty(CurrentClient.Password))
                return false;
            return true;
        }

        protected override void OnDispose()
        {
            this.Clients.Clear();
        }
    }
}
