
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

        


        public EncodageNouvelleMachineVM(ClientCollection clients,Machines m , MachinCollection machines )
        {
            Clients = clients;
            ThisMachine = m;
            Machins = machines;
        }

        //collection of clients 
        public ClientCollection Clients { get; set; }

        public MachinCollection Machins { get;set; }





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

               // ThisMachine.ClientName = _clientSelected.FirstName;//affectation  de nom de client a la machine 
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
