using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    public class MachinCollection : ObservableCollection<Machines>
    {



        public void AddMachin(Machines machin)
        {
            this.Add(machin);

        }//end AddClient

        public Machines New_machine(string machinSelected)
        {
            if (!string.IsNullOrEmpty(machinSelected))
            {
                if (machinSelected.Equals("TailleHaie"))
                {
                    TailleHaie t = new TailleHaie(DateTime.Now,DateTime.Now.AddDays(14));
                    t.IdMachine = bildIdMachine();
                    return t;
                }
                else if (machinSelected.Equals("Tondeuse"))
                {
                    Tondeuse tn = new Tondeuse(DateTime.Now, DateTime.Now.AddDays(14));
                    tn.IdMachine = bildIdMachine();
                    return tn;
                }
                else 
                {
                    TracteurTondeuse tt = new TracteurTondeuse(DateTime.Now, DateTime.Now.AddDays(14));
                    tt.IdMachine = bildIdMachine();
                    return tt;
                }
               
            }
            else
            {
                return null;
            }

           
        }

        /// <summary>
        /// a method for counting IdMachind
        /// </summary>
        /// <returns> integer IdMachind </returns>

        public int bildIdMachine()

        {
            if (this.Count == 0) { return 1; }
            else return this.Count + 1;
        }

    }//end class 
}//end project Jarditech
