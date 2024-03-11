using System.Data.Entity;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataLayerLib;
using MVVM_Lib;

namespace DaataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                HospitalDBContext DB = new HospitalDBContext();
                DB.Database.EnsureDeleted();
                DB.Database.EnsureCreated();
                this.DataContext = new HospitalViewModel().Init(DB);
                int numExam = DB.Examinations.Count()+1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}