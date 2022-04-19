using Jarditech.Models;
using Jarditech.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Jarditech.Views
{
    /// <summary>
    /// Logique d'interaction pour RepairMachineWindow.xaml
    /// </summary>
    public partial class RepairMachineWindow : Window
    {
        RepairMachineWindowVM RepairVM { get; set; }



        public RepairMachineWindow(Machines m , ClientCollection clients )
        {
            RepairVM = new RepairMachineWindowVM(m,clients);
            DataContext = RepairVM;
            InitializeComponent();
        }

        private void ExitWorkMachine_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenClientFile_Click(object sender, RoutedEventArgs e)
        {
            EncodageClientWindow ClientFile = new EncodageClientWindow(RepairVM.Clients,RepairVM.SelectedMachine.Client);
            ClientFile.Show();

        }

    }
}
