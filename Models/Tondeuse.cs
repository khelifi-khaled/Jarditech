using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    public  class Tondeuse : Machines
    {
        public Tondeuse(string clientName, int idMachine = 0, string constructeurMachine = "", string referenceMachine = "", string descriptionClient = "", string workDescription = "", bool entretenir = false, bool repar = false, double price = 0.0, int workTime = 0)
          : base(clientName, idMachine, constructeurMachine, referenceMachine, descriptionClient, workDescription, entretenir, repar, price, workTime)
        {

        }//end  Tondeuse 

        public Tondeuse() { }
        public Tondeuse(DateTime depoDate, DateTime retraitDate) : base(depoDate, retraitDate) { }


    }//end class Tondeuse 


}//end Jarditech 
