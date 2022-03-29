using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    public class TracteurTondeuse : Machines
    {
        private bool _replaceBattery;
        private double _priceBattery;


        public TracteurTondeuse(string clientName, int idMachine = 0, string constructeurMachine = "", string referenceMachine = "", string descriptionClient = "", string workDescription = "", bool entretenir = false, bool repar = false, double price = 0.0, int workTime = 0, bool replaceBattery = false, double priceBattery = 0.0)
           : base(clientName, idMachine, constructeurMachine, referenceMachine, descriptionClient, workDescription, entretenir, repar, price, workTime)
        {
            _replaceBattery = replaceBattery;
            _priceBattery = priceBattery;

        }//end constr TailleHaie 

        public TracteurTondeuse() { }

        public TracteurTondeuse(DateTime depoDate, DateTime retraitDate) : base(depoDate, retraitDate) { }



        public bool ReplaceBattery
        {
            get
            { 
                return _replaceBattery;
            }
            set
            {
                _replaceBattery = value;
            }
        
        }

        public double PriceBattery
        {
            get
            {
               return  _priceBattery ;
            }
            set
            {
                _priceBattery = value;
            }

        }



    }//end class Tracteur



}//end Jarditech
