using Jarditech.Utilities.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarditech.Models
{
    public class Client
    {
        private int _idClient;
        private string _firstName;
        private string _lastName;
        private string _adress;
        private string _mailClient;
        private string _phoneClient;


       




        public Client(string firsname="",string lastname="",string adress="",string mailClient="",string phoneClient="")
        {
            _firstName = firsname;
            _lastName = lastname;
            _adress= adress;
            _mailClient = mailClient;
            _phoneClient = phoneClient;
           

        }//end 

        [JsonProperty]
        public int IdClient
        {
            get 
            { 
                return _idClient;
            }
            set 
            { 
                _idClient =value;
            }
        }

        [JsonProperty]
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        [JsonProperty]
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set 
            {
                _lastName = value;
            }
        }

        [JsonProperty]
        public string  Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress= value;
            }
        }
        [JsonProperty]
        public string MailClient
        {
            get
            {
                return _mailClient;
            }
            set
            {
                _mailClient = value;
            }
        }



        [JsonProperty]
        public string PhoneClient
        {
            get
            {
                return _phoneClient;
            }
            set 
            { 
                _phoneClient = value;
            }
        }

        

      


    }//end Class  Client

}//end Priject  Jarditech
