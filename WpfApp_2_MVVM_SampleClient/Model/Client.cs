using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_2_MVVM_SampleClient
{
    public class Client
    {
        public string FirstName { get; set; }
        public string Password { get; set; }

       
        public Client() {}
      
        public Client(string firstName, string password)
        {
            FirstName = firstName;
            Password = password;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, Password);
        }
    }
}
