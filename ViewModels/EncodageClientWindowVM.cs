using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using System.ComponentModel;


namespace Jarditech.ViewModels
{
    public  class EncodageClientWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private Client _clientEnCoursEncodage;



      


        private const string CLIENTS_JSON_FILE = @"C:\Users\Admin\source\repos\Jarditech\JsonClient.json";




        public EncodageClientWindowVM()
        {
            ClientDataAccess = new DataAccessJsn(CLIENTS_JSON_FILE, new string[] { "json" });
            Clients = ClientDataAccess.GetClientDatas();
            ClientEnCoursEncodage = new Client();

        }






        /// <summary>
        /// Collection of all Clients in the databse (source file)
        /// </summary> 
        public ClientCollection Clients 
        {
            get;set;
        }




        public DataAccess ClientDataAccess { get; set; }
        



        public Client ClientEnCoursEncodage
        {
            get
            {
                return _clientEnCoursEncodage;
            }

            set
            {
               if (ClientEnCoursEncodage==null)
                {
                    _clientEnCoursEncodage = new Client ();
                    OnPropertyChanged(nameof(ClientEnCoursEncodage));
                }
               else
                {
                    _clientEnCoursEncodage = value;
                    OnPropertyChanged(nameof(ClientEnCoursEncodage));
                }

            }


        }




        public  int BuildIdClient()

        {

            int id = 0;

            if (Clients == null)
            {
                id = 1;
            }
            else
            {
                id = Clients.Count + 1;
            }

            return id;

        }//end BuildIdClient






        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        


    }//end class 


}//end  Jarditech 
