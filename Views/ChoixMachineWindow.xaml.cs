using Jarditech.Models;
using Jarditech.ViewModels;
using System.Windows;

namespace Jarditech.Views
{
    /// <summary>
    /// Logique d'interaction pour ChoixMachineWindow.xaml
    /// </summary>
    public partial class ChoixMachineWindow : Window
    {
        private ChoixMachineVM ChoixVM { get; set; }

        

        public ChoixMachineWindow(MachinCollection machines , ClientCollection clients)
        {
            ChoixVM = new ChoixMachineVM(machines,clients);
            DataContext = ChoixVM;
            InitializeComponent();
        }

        private void BtnSelectionMachin_Click(object sender, RoutedEventArgs e)
        {
            ChoixVM.SelectedMachine = ChoixVM.Machines.Nouvelle_machine(ChoixVM.Machin_selecte_name);

            if (ChoixVM.SelectedMachine!=null)
            { 
                ChoixVM.Machines.AddMachin(ChoixVM.SelectedMachine);

                EncodageNouvelleMachineWindow ourmachine = new EncodageNouvelleMachineWindow(ChoixVM.Clients, ChoixVM.SelectedMachine, ChoixVM.Machines);
                ourmachine.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"mon chère utilisateur , j'ai  pas de Machine sélectionner, du coup sélectionne une Machine pour moi stp , a fin que je poisse  t'en crier une.","Mssg Err");
            }

            
        }

    }
}
