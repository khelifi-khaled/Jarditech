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

        public ClientCollection Clients { get; set; }
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
            //EncodageClientVM.ClientDataAccess.UpdateAllClientsDatas(EncodageClientVM.Clients);
        }

        private void NewMachine_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewNewClient_Click(object sender, RoutedEventArgs e)
        {
            
            EncodageClientWindow client = new EncodageClientWindow(MainVM.Clients,MainVM.AccessjsonClient);
            client.Show();
        }

        private void ButtonTestCreateClient_Click(object sender, RoutedEventArgs e)
        {
            //Client c = new Client("khaled", "khelifi", "Mons", "khaled@gmail.com", "0123456456");
            //Client c2 = new Client("tot", "tot", "Mons", "khaled@totogmail.com", "tototot");
            //ClientCollection col = new ClientCollection();
            //col.Add(c);
            //col.Add(c2);
            //DataAccessJsn json = new DataAccessJsn(@"C:\Users\Admin\source\repos\Jarditech\JsonClient.json", new string[] { "json" });
            //json.UpdateAllClientsDatas(col);
        }

        private void ButtonTestCreateMachine_Click(object sender, RoutedEventArgs e)
        {
            //Client c = new Client("toto", "titi", "Mons", "khaled@gmail.com", "01599999999996");
            //TailleHaie t1 = new TailleHaie(c,15,"reno","123456","problem","lol",true,true,15.99,60,true,20);
            //MachinCollection colm = new MachinCollection();
            //colm.Add(t1);
            //DataAccessJsn jsonm = new DataAccessJsn(@"C:\Users\Admin\source\repos\Jarditech\JsonMachine.json", new string[] { "json" });
            //jsonm.UpdateAllMachinsDatas(colm);
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
