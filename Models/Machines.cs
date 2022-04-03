using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    abstract public class Machines
    {

        private const int DAYS_OF_WORK = 14;





        private int _idMachin;
        private string _constructeurMachine;
        private string _referenceMachine;
        private DateTime _depoDate;
        private DateTime _retraitDate;
        private Client _client;
        private string _descriptionClient;
        private string _workDescription;
        private bool _entretenir;
        private bool _repar;
        private double _price;
        private int _workTime;
        private string _machineStatus;




        public Machines() { }


        public Machines(DateTime depoDate, DateTime retraitDate)
        {
            _depoDate = depoDate;
            _retraitDate = retraitDate;
            
        }

        public Machines(Client client, int idMachine = 0, string constructeurMachine = "", string referenceMachine = "", string descriptionClient = "", string workDescription = "", bool entretenir = false, bool repar = false, double price = 0.0, int workTime = 0)
        {
            _idMachin = idMachine;
            _constructeurMachine = constructeurMachine;
            _referenceMachine = referenceMachine;
            _client = client;
            _descriptionClient = descriptionClient;
            _workDescription = workDescription;
            _entretenir = entretenir;
            _repar = repar;
            _price = price;
            _workTime = workTime;

        }//end Machines




        [JsonProperty]
        public int IdMachine
        {
            get
            {
                return _idMachin;
            }
            set
            {
                _idMachin = value;
            }
        }


        [JsonProperty]
        public string ConstructeurMachine
        {
            get
            {
                return _constructeurMachine;
            }
            set
            {
                _constructeurMachine = value;
            }
        }

        [JsonProperty]
        public string ReferenceMachine
        {
            get
            {
                return _referenceMachine;
            }
            set
            {
                _referenceMachine = value;

            }
        }

        [JsonProperty]
        public DateTime DepoDate
        {
            get
            {
                return _depoDate;
            }

            set
            {
                _depoDate = DateTime.Now;
            }
        }

        [JsonProperty]
        public DateTime RetraitDate
        {
            get
            {
                return _retraitDate;
            }
            set
            {
                _retraitDate = DepoDate.AddDays(DAYS_OF_WORK);
            }
        }


        [JsonProperty]
        public Client Client
        {
            get { return _client; }

            set
            {
                _client = value;
            }
        }


        [JsonProperty]
        public string DescriptionClient
        {
            get
            {
                return _descriptionClient;
            }
            set
            {
                _descriptionClient = value;
            }
        }



        [JsonProperty]
        public string WorkDescription
        {
            get
            {
                return _workDescription;
            }
            set
            {
                _workDescription = value;
            }
        }



        [JsonProperty]
        public bool Entretenir
        {
            get
            {
                return _entretenir;
            }
            set
            {
                _entretenir = value;
            }
        }



        [JsonProperty]
        public bool Repar
        {
            get
            {
                return _repar;
            }
            set
            {
                _repar = value;

            }
        }



        [JsonProperty]
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }


        [JsonProperty]
        public int WorkTime
        {
            get
            {
                return _workTime;
            }
            set
            {
                _workTime = value;
            }
        }


        [JsonProperty]
        public string MachineStatus
        {
            get
            {
                return _machineStatus;
            }
            set
            {
                _machineStatus = value;
            }
        }



    }//end Class Machines 

  

}//end project Jarditech
