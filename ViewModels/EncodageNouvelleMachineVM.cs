
using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Jarditech.ViewModels
{
    public  class EncodageNouvelleMachineVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       
        private Client _clientSelected;
        private Machines _thisMachine;

        private const string CLIENTS_JSON_FILE = @"C:\Users\Admin\source\repos\Jarditech\JsonClient.json";
        private const string MACHINS_JSON_FILE = @"C:\Users\Admin\source\repos\Jarditech\JsonMachine.json";


        public EncodageNouvelleMachineVM()
        {
            AccessjsonMachine = new DataAccessJsn(MACHINS_JSON_FILE, new string[] { "json" });
            AccessjsonClient = new DataAccessJsn(CLIENTS_JSON_FILE, new string[] { "json" });
            Machines = AccessjsonMachine.GetMachinDatas();
            Clients = AccessjsonClient.GetClientDatas();

        }

        //collection of clients 
        public ClientCollection Clients { get; set; }

        public MachinCollection Machines { get; set; }

        public DataAccessJsn AccessjsonMachine { get; set; }
        public DataAccessJsn AccessjsonClient { get; set; }

        //for reading our JsonFile 
        public DataAccess ClientDataAccess { get; set; }


        public Machines ThisMachine
        {
            get
            {
                return _thisMachine;
            }
            set
            {
                _thisMachine = value;
                OnPropertyChanged(nameof(ThisMachine));
            }
        }



        //for the client selected 
        public Client ClientSelected
        { 
            get 
            {
                List<Client> clients = Clients.ToList<Client>();

                _clientSelected = clients.Find(c => c.FirstName.Equals(ClientNameSelected)); //trouver le client qui correspond au nom choisi 

                ThisMachine.ClientName = _clientSelected.FirstName;//affectation  de nom de client a la machine 
                return _clientSelected;
                
            }
            set 
            {
                _clientSelected = value;
                OnPropertyChanged(nameof(ClientSelected));
            }
        }

        public string ClientNameSelected { get; set; }


        public string [] ClientsNames
        {
            get { return Clients.Select(c => c.FirstName).ToArray(); }
            set { }
        }

        







        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }//end EncodageNouvelleMachineVM
}//end Jarditech
