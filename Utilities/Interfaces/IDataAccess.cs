using Jarditech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Utilities.Interfaces
{
    public  interface IDataAccess
    {
        /// <summary>
        /// Access string to the external source (file path, connections tring ...)
        /// </summary>
        string AccessPath
        {
            get;
            set;
        }


        /// <summary>
        /// retrieve Client's informations from the external source
        /// </summary>
        /// <returns>a UserCollection </Client>
        ClientCollection GetClientDatas();

        /// <summary>
        /// retrieve Machin's informations from the external source
        /// </summary>
        /// <returns>a UserCollection </Machins>
        MachinCollection GetMachinDatas();


        /// <summary>
        /// update all Clients datas from the Client collection to the external source
        /// </summary>
        /// <param name="uc"></param>
        void UpdateAllClientsDatas(ClientCollection uc);

        /// <summary>
        /// update all Machins datas from the Machin Collection to the external source
        /// </summary>
        /// <param name="uc"></param>
        void UpdateAllMachinsDatas(MachinCollection uc);




    }
}
