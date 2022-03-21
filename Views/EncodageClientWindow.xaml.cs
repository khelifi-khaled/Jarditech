using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using System.Windows;


namespace Jarditech.Views
{
    /// <summary>
    /// Logique d'interaction pour EncodageClientWindow.xaml
    /// </summary>
    public partial class EncodageClientWindow : Window

    {
        


        private Client ThisClient { get; set; }

        private DataAccess ClientsDataAccess { get; set; }

        private ClientCollection Clients { get; set; }



        public EncodageClientWindow(Client C,  ClientCollection Clts ,  DataAccess CDataAccess)
        {
            ThisClient = C;
            Clients = Clts;
            DataContext = ThisClient;
            ClientsDataAccess = CDataAccess;
            InitializeComponent();
            

        }//end EncodageClientWindow

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            // check si la list des  clients vide ou pas 

            if (Clients == null)
            {
                Clients = new ClientCollection();

            }

            ThisClient.IdClient = BuildIdClient();

            Clients.Add(ThisClient);

            MessageBox.Show($"le client {ThisClient.LastName} {ThisClient.FirstName} a été bien ajouté à la liste des clients" , "Nouveau Client ");
           
           
            //normalement on n'aura pas besoin de ça demain la sauvegard se fais aprés
            //le ClientEnCoursEncodage est bien enregistrer dans la liste 

            //ClientsDataAccess.UpdateAllClientsDatas(Clients);


        }//end ButtonSave_Click

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }//end ButtonCancel_Click

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {



        }//end ButtonNew_Click




        private int BuildIdClient()

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





    }
}
