
using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using System;
using System.ComponentModel;




namespace Jarditech.ViewModels
{
    public  class ChoixMachineVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private  string[] _list_type_machin = { "TailleHaie", "Tondeuse", "TracteurTondeuse" };






        public ChoixMachineVM(MachinCollection machines, ClientCollection clients)
        {
            Machines = machines;
            Clients = clients;

        }//end ChoixMachineVM

       
        public  MachinCollection Machines { get; set; }


        public ClientCollection Clients { get; set; }


        public  Machines SelectedMachine
        {
            get;set;
        }




        public string [] List_type_machin 
        { 
            get
            {
                return _list_type_machin;
            }
            set
            {
                _list_type_machin = value;
                OnPropertyChanged(nameof(List_type_machin));
            }
        }




        public string Machin_selecte_name
        {
            get;set;
        }



      



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }//end class 


}//end Jarditech
