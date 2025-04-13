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

namespace VetClinika.Windows
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Btn_closed_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_minimaze_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Profil_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Pages.Profil());
        }

        private void Btn_Services_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Pages.ServiceClient());
        }

        private void Btn_Zapises_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Contact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if(MainFrame.IsEnabled == true)
            {
                St_Dobro.Visibility = Visibility.Collapsed;
            }
            else
            {
                St_Dobro.Visibility = Visibility.Visible;
            }
        }
    }
}
