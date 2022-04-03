using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using System.ComponentModel;


namespace Jarditech.ViewModels
{
    public  class EncodageClientWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private Client _clientEnCoursEncodage;



      


        




        public EncodageClientWindowVM(ClientCollection clients , Client client)
        {
            ClientEnCoursEncodage = client;
            Clients=clients;

        }//end EncodageClientWindowVM


        public EncodageClientWindowVM(Client client)
        {
            ClientEnCoursEncodage = client;

        }//end EncodageClientWindowVM








        /// <summary>
        /// Collection of all Clients in the databse (source file)
        /// </summary> 
        public ClientCollection Clients 
        {
            get;set;
        }




        



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
