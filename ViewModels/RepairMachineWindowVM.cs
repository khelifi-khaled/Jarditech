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
        private string _actuelMachineStatus; 


        public RepairMachineWindowVM(Machines m,Client c,ClientCollection clients)
        {
            SelectedMachine = m;
            ThisClient = c;
            Clients = clients;  
        }


        public ClientCollection Clients { get; set; }

        public Client ThisClient { get; set; }

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


        public string ActuelMachineStatus
        {
           get
            {
               return _actuelMachineStatus;
            }
            set 
            {
                _actuelMachineStatus = value;
                OnPropertyChanged(nameof(ActuelMachineStatus));
            }
        }


        public string [] MachineStatusList
        {
            get
            {
                return _machineStatus;
            }
            set
            {
                _machineStatus = value;
                OnPropertyChanged(nameof(MachineStatusList));
            }
        }

        






        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }//end class 
}//end Jarditech 
