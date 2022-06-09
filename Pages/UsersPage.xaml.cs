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

namespace FridgeManagementApplication.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            SelectedUser.Content = SelectedHolder.SelectedHolderName;
            UpdateUsersList();

        }

        /// <summary>
        /// UpdateUsersList Method
        /// </summary>


        private void UpdateUsersList()
        {
            UsersList.Items.Clear();
            FridgeMgDBEntities db = new FridgeMgDBEntities();

            IQueryable<Users> usrs = db.Users;

            foreach (var usr in usrs)
            {
                UsersList.Items.Add($"{usr.id}-{usr.user_name}");
            }
        }

        //TODO : ADD USER BY ENTER METHOD
      
        /// <summary>
        /// AddUser Method
        /// </summary>
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if (NewUserNick.Text != "")
            {
                FridgeMgDBEntities db = new FridgeMgDBEntities();

                Users userObject = new Users()
                {
                    user_name = NewUserNick.Text
                };
                db.Users.Add(userObject);
                db.SaveChanges();
                UpdateUsersList();
                NewUserNick.Clear();
            }
        }

        //TODO : ADD ALETR "are u sure want to remove user"
        //TODO : CANT REMOVE USER INSIDE RAPORTS TABLE
        /// <summary>
        /// RemoveUser Method
        /// </summary>
        private void RemoveUser_Click(object sender, RoutedEventArgs e)
        {
            if (UsersList.SelectedItem != null)
            {
                FridgeMgDBEntities db = new FridgeMgDBEntities();

                var selected = UsersList.SelectedItem.ToString().Split('-')[1];
                IQueryable<Users> userToRemove = db.Users.Where(el => el.user_name == selected);
               

                if (MessageBox.Show("Are you sure want to remove User?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No) { }

                else
                {
                    db.Users.RemoveRange(userToRemove);
                    db.SaveChanges();
                    UpdateUsersList();
                }


            }
        }

        /// <summary>
        /// Selectinguser Method
        /// </summary>
        private void UsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsersList.SelectedItem != null)
            {
                string thisUser_name = UsersList.SelectedItem.ToString().Split('-')[1];
                string thisUser_id = UsersList.SelectedItem.ToString().Split('-')[0];
                SelectedHolder.SelectedHolderName = thisUser_name;
                SelectedHolder.SelectedHolderId = int.Parse(thisUser_id);
                SelectedUser.Content = SelectedHolder.SelectedHolderName;
            }
            else
            {
                SelectedUser.Content = "";
                SelectedHolder.SelectedHolderName = "";
                SelectedHolder.SelectedHolderId = 0;
            }
        }
    }
}