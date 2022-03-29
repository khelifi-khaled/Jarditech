
using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using System;
using System.ComponentModel;




namespace Jarditech.ViewModels
{
    public  class ChoixMachineVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private  string[] _liste_type_machin = { "TailleHaie", "Tondeuse", "TracteurTondeuse" };
       






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




        public string [] Liste_type_machin 
        { 
            get
            {
                return _liste_type_machin;
            }
            set
            {
                _liste_type_machin = value;
                OnPropertyChanged(nameof(Liste_type_machin));
            }
        }

        public string Machin_selecte_name
        {
            get;set;
        }

        /// <summary>
        /// a method for counting IdMachind
        /// </summary>
        /// <returns> integer IdMachind </returns>
        public int bildIdMachine()
        {
            if (Machines == null) { return 1; }
            else return Machines.Count+1;
               

        }

        public Machines Nouvelle_machine(string machinSelected)
        {
            

            if (Machin_selecte_name.Equals("TailleHaie"))
            {
                TailleHaie t =  new TailleHaie (DateTime.Now, DateTime.Now.AddDays(14));
                t.IdMachine = bildIdMachine();
                return t;
                
            }
            else if (Machin_selecte_name.Equals("Tondeuse"))
            {
                Tondeuse tn = new Tondeuse(DateTime.Now, DateTime.Now.AddDays(14));
                tn.IdMachine= bildIdMachine(); 
                return tn;
               
            }
            else
            {
                TracteurTondeuse tt= new TracteurTondeuse(DateTime.Now, DateTime.Now.AddDays(14));
                tt.IdMachine= bildIdMachine();
                return tt;
                
            }
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }//end class 


}//end Jarditech
