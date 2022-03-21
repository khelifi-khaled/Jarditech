using Jarditech.Models;
using Jarditech.Utilities.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;


namespace Jarditech.Utilities.DataAccess
{
    public class DataAccessJsn : DataAccess , IDataAccess 


    {
        public DataAccessJsn(string filePath) : base(filePath) { }

        public DataAccessJsn (string filePath, string[] extensions) : base(filePath, extensions) { }


        

        /// <summary>
        /// retrieve Cliens collection datas from the datasource Json file
        /// </summary>

        public override ClientCollection GetClientDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                ClientCollection clients = new ClientCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (client)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                clients = JsonConvert.DeserializeObject<ClientCollection>(jsonFile, settings);

                return clients;

            }

            else
            {
             
                return null;
            }
        }//end GetClientsDatas


        /// <summary>
        /// retrieve Machins collection datas from the datasource Json file
        /// </summary>

        public override MachinCollection GetMachinDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                MachinCollection machins = new MachinCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (machin)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                machins = JsonConvert.DeserializeObject<MachinCollection>(jsonFile, settings);

                return machins;

            }

            else
            {
              
                return null;
            }
        }//end GetMachinDatas


        /// <summary>
        /// update all Clients datas from the Client collection to the external source
        /// </summary>
        /// <param name="uc"></param>
        public override void UpdateAllClientsDatas(ClientCollection uc)
        {
            if (IsValidAccessPath)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                string json = JsonConvert.SerializeObject(uc, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented, settings);

                File.WriteAllText(AccessPath, json);
            }
            else
            {
                Console.WriteLine("UpdateAllClientsDatas error can't update datasource file");
            }
        }

        /// <summary>
        /// update all Machins datas from the Machin Collection to the external source
        /// </summary>
        /// <param name="uc"></param>
        public override void UpdateAllMachinsDatas(MachinCollection uc)
        {
            if (IsValidAccessPath)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                string json = JsonConvert.SerializeObject(uc, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented, settings);

                File.WriteAllText(AccessPath, json);
            }
            else
            {
                Console.WriteLine("UpdateAllMachinsDatas error can't update datasource file");
            }
        }







    }//end class 
}
