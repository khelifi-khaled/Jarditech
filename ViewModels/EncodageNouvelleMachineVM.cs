
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
        private string _clientNameSelected;




        public EncodageNouvelleMachineVM(ClientCollection clients,Machines m , MachinCollection machines)
        {
            Clients = clients;
            ThisMachine = m;
            Machins = machines;
        }

        

        public EncodageNouvelleMachineVM() { }


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



       

       

      



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }//end EncodageNouvelleMachineVM
}//end Jarditech
