using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Jarditech.Models
{
    public  class ClientCollection : ObservableCollection<Client>
    {
       


        public Client GetClient(string clientNameSelected)
        {
            List<Client> clients = this.ToList<Client>();

            return clients.Find(c => c.FullName.Equals(clientNameSelected)); //trouver le client qui correspond au nom choisi 
        }

        
    }
}
