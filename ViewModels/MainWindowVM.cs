using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.ViewModels
    
{
  

    public class MainWindowVM : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Machines _selMachine;

        private const string MACHINS_JSON_FILE = @"C:\Users\Admin\source\repos\Jarditech\JsonMachine.json";

        private const string CLIENTS_JSON_FILE = @"C:\Users\Admin\source\repos\Jarditech\JsonClient.json";


        public ClientCollection  Clients { get; set; }

        public MachinCollection Machines { get; set; }

        public DataAccessJsn AccessjsonMachine { get; set; }

         public DataAccessJsn AccessjsonClient { get; set; }



        public Machines SelMachine 
        {
            get
            {
                return _selMachine;
            }
            set
            {
                _selMachine = value;
                OnPropertyChanged(nameof(SelMachine));
            }
        }

        public Client ThisClient { get;set; }




        public MainWindowVM()
        {
            AccessjsonMachine = new DataAccessJsn(MACHINS_JSON_FILE, new string[] { "json" });
            AccessjsonClient = new DataAccessJsn(CLIENTS_JSON_FILE, new string[] { "json" });
            Machines = AccessjsonMachine.GetMachinDatas();
            Clients = AccessjsonClient.GetClientDatas();
            

        }


       


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }//end class 

}//end Jarditech
