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
using VetClinika.Windows;

namespace VetClinika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_closed_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_minimaze_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TbNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_Open_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Show();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Owner = this;
            this.Close();
        }

        private void Btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Owner = this;
            this.Close();
        }
    }
}
