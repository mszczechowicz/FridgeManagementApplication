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

            IQueryable<Raports> events = db.Raports.OrderByDescending(e=>e.action_time);
            foreach (var eve in events)
            {
                RaportsList.Items.Add($"{eve.id}-{eve.Users.user_name}-{eve.add_remove}-{eve.raport_quantity}-{eve.product_name_rap}-{eve.action_time}");
            }

        }
    }
}
