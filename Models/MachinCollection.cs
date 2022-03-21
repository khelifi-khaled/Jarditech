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
    }//end class 
}//end project Jarditech
