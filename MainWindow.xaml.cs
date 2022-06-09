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

namespace FridgeManagementApplication
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Pages.UsersPage();
        }

        private void UsersPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Pages.UsersPage();
        }

        private void FridgePage_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedHolder.SelectedHolderName != "")
            {
                Main.Content = new Pages.FridgePage();
            }
            else
            {
                MessageBox.Show("Select User from List");
            }
        }

        private void CategoriesPage_Click(object sender, RoutedEventArgs e)
        {


            if (SelectedHolder.SelectedHolderName != "")
            {
                Main.Content = new Pages.CategoriesPage();
            }
            else
            {
                MessageBox.Show("Select User from List");
            }
        }

        private void EventsPage_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedHolder.SelectedHolderName != "")
            {
                Main.Content = new Pages.EventsPage();
            }
            else
            {
                MessageBox.Show("Select User from List");
            }
        }
    }
}
