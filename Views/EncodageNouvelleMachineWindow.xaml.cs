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


        public EncodageNouvelleMachineWindow(ClientCollection clients,Machines machine, MachinCollection machines)
        {
            MachinesVM = new EncodageNouvelleMachineVM(clients, machine, machines);
            DataContext = MachinesVM;
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Fiche_Client_Click(object sender, RoutedEventArgs e)
        {
            EncodageClientWindow FicheClient = new EncodageClientWindow(MachinesVM.ClientSelected);
            FicheClient.Show();
        }
    }
}
