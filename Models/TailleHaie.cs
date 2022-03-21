﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    public  class TailleHaie : Machines
    {
        private bool _sharpening;
        private double _price_sharpening;


        public TailleHaie(Client client, int idMachine = 0, string constructeurMachine = "", string referenceMachine = "", string descriptionClient = "", string workDescription = "", bool entretenir = false, bool repar = false, double price = 0.0, int workTime = 0, bool sharpening = false, double price_sharpening = 0.0) 
            : base (client, idMachine, constructeurMachine, referenceMachine, descriptionClient, workDescription, entretenir, repar, price, workTime)
        {
            _sharpening = sharpening;
            _price_sharpening = price_sharpening;

        }//end constr TailleHaie 

        public TailleHaie() { }




    }//end TailleHaie


}//end Jarditech



