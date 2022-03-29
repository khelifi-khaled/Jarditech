using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
using Jarditech.ViewModels;
using System.Windows;


namespace Jarditech.Views
{
    /// <summary>
    /// Logique d'interaction pour EncodageClientWindow.xaml
    /// </summary>
    public partial class EncodageClientWindow : Window

    {

        public EncodageClientWindowVM  EncodageVM
        {
            get; set;
        }
    

        public  ClientCollection Clients { get; set; }



        public EncodageClientWindow( ClientCollection Clts, Client c )
        {
            EncodageVM = new EncodageClientWindowVM(Clts,c);
            DataContext = EncodageVM;
            InitializeComponent();

        }//end EncodageClientWindow

        public EncodageClientWindow( Client c)
        {
            EncodageVM = new EncodageClientWindowVM( c);
            DataContext = EncodageVM;
            InitializeComponent();

        }//end EncodageClientWindow




        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            

            // check si la list des  clients vide ou pas 

            if (EncodageVM.Clients == null)
            {
                EncodageVM.Clients = new ClientCollection();

            }

            EncodageVM.ClientEnCoursEncodage.IdClient = EncodageVM.BuildIdClient();

            EncodageVM.Clients.Add(EncodageVM.ClientEnCoursEncodage);

           

            MessageBox.Show($"le client {EncodageVM.ClientEnCoursEncodage.LastName} {EncodageVM.ClientEnCoursEncodage.FirstName} a été bien ajouté à la liste des clients" , "Nouveau Client ");


           NumClient.Text = EncodageVM.ClientEnCoursEncodage.IdClient.ToString();



        }//end ButtonSave_Click

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            EncodageVM.ClientEnCoursEncodage =null;
            this.Close();

        }//end ButtonCancel_Click

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            EncodageVM.ClientEnCoursEncodage = new Client();


        }//end ButtonNew_Click



        






    }//end class 
}//end project 
