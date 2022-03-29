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

        private Machines selectedMachine { get; set; }

        public ChoixMachineWindow()
        {
            ChoixVM = new ChoixMachineVM();
            DataContext = ChoixVM;
            InitializeComponent();
        }

        private void BtnSelectionMachin_Click(object sender, RoutedEventArgs e)
        {
            selectedMachine = ChoixVM.Nouvelle_machine(ChoixVM.Machin_selecte_name);
            ChoixVM.Machines.Add(selectedMachine);
            ChoixVM.AccessjsonMachine.UpdateAllMachinsDatas(ChoixVM.Machines);

            EncodageNouvelleMachineWindow ourmachine = new EncodageNouvelleMachineWindow(selectedMachine);
            ourmachine.Show();
            this.Close();
        }

    }
}
