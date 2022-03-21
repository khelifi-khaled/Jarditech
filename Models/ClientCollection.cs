using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    public  class ClientCollection : ObservableCollection<Client>
    {



        public void AddClient(Client client)
        {
            this.Add(client);

        }//end AddClient

        
    }
}
