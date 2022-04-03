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
            MachinesVM = new EncodageNouvelleMachineVM(clients, machine, machines );
            DataContext = MachinesVM;
            
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, RoutedEventArgs e)
        {
            
            
            this.Close();
        }

        private void Fiche_Client_Click(object sender, RoutedEventArgs e)
        {
            MachinesVM.ClientSelected = MachinesVM.Clients.GetClient(MachinesVM.ClientNameSelected);
            MachinesVM.ThisMachine.Client = MachinesVM.ClientSelected;

            if (MachinesVM.ClientSelected!=null)
            {
                EncodageClientWindow FicheClient = new EncodageClientWindow(MachinesVM.Clients, MachinesVM.ClientSelected);
                FicheClient.Show();
            }
            else
            {
                MessageBox.Show($"Mon cher utilisateur, je n'ai pas de client sélectionné, du coup, sélectionne un client pour moi stp, afin que je puisse t'afficher sa fiche client.", "Mssg Err");
            }
        }
    }
}
