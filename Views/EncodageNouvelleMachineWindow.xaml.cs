using Jarditech.Models;
using Jarditech.ViewModels;
using System.Windows;


namespace Jarditech.Views
{

   


    public partial class EncodageNouvelleMachineWindow : Window

    {

        public EncodageNouvelleMachineVM MachinesVM
        {
            get; set;
        }


        public EncodageNouvelleMachineWindow(Machines machine )
        {
            MachinesVM = new EncodageNouvelleMachineVM();
            MachinesVM.ThisMachine = machine;
            DataContext = MachinesVM;
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Fiche_Client_Click(object sender, RoutedEventArgs e)
        {
            EncodageClientWindow FicheClient = new EncodageClientWindow(MachinesVM.ClientSelected,MachinesVM.Clients,MachinesVM.ClientDataAccess);
            FicheClient.Show();
        }
    }
}
