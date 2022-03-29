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
        private string _clientName;
        private string _descriptionClient;
        private string _workDescription;
        private bool _entretenir;
        private bool _repar;
        private double _price;
        private int _workTime;




        public Machines() { }


        public Machines(DateTime depoDate,DateTime retraitDate) 
        {
            _depoDate = depoDate;
            _retraitDate = retraitDate;
        }

        public Machines(string clientName, int idMachine = 0, string constructeurMachine = "", string referenceMachine = "", string descriptionClient = "", string workDescription = "", bool entretenir = false, bool repar = false, double price = 0.0,int workTime=0)
        {
            _idMachin = idMachine;
            _constructeurMachine = constructeurMachine;
            _referenceMachine = referenceMachine;
            _clientName = clientName;
            _descriptionClient = descriptionClient;
            _workDescription = workDescription;
            _entretenir = entretenir;
            _repar = repar;
            _price = price;
            _workTime = workTime;

        }//end Machines



 

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



        public string ConstructeurMachine
        {
            get
            {
                return _constructeurMachine;
            }
            set
            {
                _constructeurMachine= value;
            }
        }


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

        public  DateTime DepoDate
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


        public  DateTime RetraitDate
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



        public string ClientName
        {
            get { return _clientName; }

            set
            {
                _clientName = value;
            }
        }



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


        public bool Repar
        {
            get
            {
                return _repar;
            }
            set
            {
                 _repar=value;

            }
        }


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



    }//end Class Machines 

}//end project Jarditech
