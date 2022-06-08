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
    /// Logika interakcji dla klasy EventsPage.xaml
    /// </summary>
    public partial class EventsPage : Page
    {
        public EventsPage()
        {
            InitializeComponent();
            UpdateEventRaports();
        }


        private void UpdateEventRaports()
        {
            RaportsList.Items.Clear();

            FridgeMgDBEntities db = new FridgeMgDBEntities();

            //IQueryable<Users> Users = db.Users.Where(el=>el.user_name == GLOBALNY.WYBRANEIDUSERA )

            //IQueryable<Users> usrs = db.Users;

            var events = from e in db.Raports
                       select e;


            foreach (var eve in events)
            {

                //UsersList.ItemsSource = db.Users.ToList();
                RaportsList.Items.Add($"{eve.id}-{eve.Users.user_name}-{eve.add_remove}-{eve.raport_quantity}-{eve.Product.product_name}-{eve.action_time}");

            }

        }
    }
}
