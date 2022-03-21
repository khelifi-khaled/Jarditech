using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    public  class Tondeuse : Machines
    {
        public Tondeuse(Client client, int idMachine = 0, string constructeurMachine = "", string referenceMachine = "", string descriptionClient = "", string workDescription = "", bool entretenir = false, bool repar = false, double price = 0.0, int workTime = 0)
          : base(client, idMachine, constructeurMachine, referenceMachine, descriptionClient, workDescription, entretenir, repar, price, workTime)
        {

        }//end  Tondeuse 

        public Tondeuse() { }


    }//end class Tondeuse 


}//end Jarditech 
