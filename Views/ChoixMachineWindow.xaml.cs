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
            ChoixVM.SelectedMachine = ChoixVM.Nouvelle_machine(ChoixVM.Machin_selecte_name);
            
            ChoixVM.Machines.Add(ChoixVM.SelectedMachine);

            EncodageNouvelleMachineWindow ourmachine = new EncodageNouvelleMachineWindow(ChoixVM.Clients,ChoixVM.SelectedMachine,ChoixVM.Machines);
            ourmachine.Show();
            this.Close();
        }

    }
}
