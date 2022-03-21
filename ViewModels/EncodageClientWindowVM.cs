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
                _clientEnCoursEncodage = value;
                OnPropertyChanged(nameof(ClientEnCoursEncodage));
            }
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }







    }//end class 


}//end  Jarditech 
