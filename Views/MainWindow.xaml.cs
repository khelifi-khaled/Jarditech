using Jarditech.Models;
using Jarditech.Utilities.DataAccess;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jarditech.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window


    {
        //prop sur le main pour utiliser dans lous Butons 

        public MainWindowVM MainVM { get; set; }

       

    public MainWindow()
        {
            MainVM = new MainWindowVM();
            DataContext = MainVM;
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sauver_Click(object sender, RoutedEventArgs e)
        {
            MainVM.AccessjsonClient.UpdateAllClientsDatas(MainVM.Clients);
            MainVM.AccessjsonMachine.UpdateAllMachinsDatas(MainVM.Machines);

            MessageBox.Show($"Sauvegarde de toutes les données effectuées");

        }

        private void NewMachine_Click(object sender, RoutedEventArgs e)
        {
            ChoixMachineWindow ChoixMachine = new ChoixMachineWindow(MainVM.Machines, MainVM.Clients);
            ChoixMachine.Show();
        }

        private void NewNewClient_Click(object sender, RoutedEventArgs e)
        {   
            Client c = new Client();
            EncodageClientWindow client = new EncodageClientWindow(MainVM.Clients, c);
            client.Show();
        }


        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            RepairMachineWindow repar = new RepairMachineWindow(MainVM.SelMachine,MainVM.SelMachine.Client, MainVM.Clients);
            repar.Show();
        }

        private void DataGrid_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            EncodageClientWindow ficheClient = new EncodageClientWindow(MainVM.ThisClient);
            ficheClient.Show();
        }
    }
}
