using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_2_MVVM_SampleClient
{
    public static class ClientRepository
    {
        private static ObservableCollection<Client> _clients;



        public static ObservableCollection<Client> AllClients
        {
            get
            {
                if (_clients == null)
                    _clients = GenerateClientRepository();
                return _clients;
            }
        }


        private static ObservableCollection<Client> GenerateClientRepository()
        {
            ObservableCollection<Client> clients = new ObservableCollection<Client>();
            clients.Add(new Client("admin", "123"));
            clients.Add(new Client("client", "123"));
            clients.Add(new Client("user", "123"));
            return clients;
        }
    }
}
