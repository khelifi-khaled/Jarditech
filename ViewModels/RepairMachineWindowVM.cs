using Jarditech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.ViewModels
{
    public  class RepairMachineWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

         private  Machines _selectedMachine;

        private string[] _machineStatus = {"Attente_Traitement","Reparation_En_Cours","Attent_Retrait", "Retrait" };
        


        public RepairMachineWindowVM(Machines m,ClientCollection clients)
        {
            SelectedMachine = m;
            Clients = clients;  
        }


        public ClientCollection Clients { get; set; }


        public Machines SelectedMachine
        {
            get
            {
                return _selectedMachine;
            }
            set
            {
                _selectedMachine = value;
                OnPropertyChanged(nameof(SelectedMachine));
            }
        }


        public string [] MachineStatus
        {
            get
            {
                return _machineStatus;
            }
            set
            {

            }
        }









        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }//end class 
}//end Jarditech 
