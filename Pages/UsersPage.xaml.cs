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


            UpdateUsersList();


        }

        private void UpdateUsersList()
        {
            UsersList.Items.Clear();
            
            FridgeManagementDBEntities db = new FridgeManagementDBEntities();

            //IQueryable<Users> Users = db.Users.Where(el=>el.user_name == GLOBALNY.WYBRANEIDUSERA )

            //IQueryable<Users> usrs = db.Users;
                
            var usrs = from d in db.Users
                       select d;
            

            foreach (var usr in usrs)
            {

                //UsersList.ItemsSource = db.Users.ToList();
                UsersList.Items.Add($"{usr.id}-{usr.user_name}");
              

            }

        }





        //TODO : ADD USER BY ENTER
        //TODO : ADD ALETRS ARE U SURE?
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {



            if (NewUserNick.Text != "")
            {
                FridgeManagementDBEntities db = new FridgeManagementDBEntities();
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
        //TODO : ADD ALETRS ARE U SURE?
        private void RemoveUser_Click(object sender, RoutedEventArgs e)
        {
            if (UsersList.SelectedItem != null)
            {
                FridgeManagementDBEntities db = new FridgeManagementDBEntities();
                var selected = UsersList.SelectedItem.ToString().Split('-')[1];
                IQueryable<Users> userToRemove = db.Users.Where(el => el.user_name == selected);
                db.Users.RemoveRange(userToRemove);
                int result = db.SaveChanges();
                UpdateUsersList();
            
            }
        }


        //TODO : ADD GLOBAL SLECTION FOR USER
    }
}