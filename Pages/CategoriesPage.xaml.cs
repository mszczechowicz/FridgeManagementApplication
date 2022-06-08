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
    /// Logika interakcji dla klasy CategoriesPage.xaml
    /// </summary>
    public partial class CategoriesPage : Page
    {
        public CategoriesPage()
        {
            InitializeComponent();
            UpdateCategoryList();

        }



        private void UpdateCategoryList()
        {



            CategoryList.Items.Clear();

            FridgeManagementDBEntities db = new FridgeManagementDBEntities();

            //IQueryable<Users> Users = db.Users.Where(el=>el.user_name == GLOBALNY.WYBRANEIDUSERA )

            //IQueryable<Users> usrs = db.Users;

            var cats = from c in db.Category
                       select c;


            foreach (var cat in cats)
            {

                //UsersList.ItemsSource = db.Users.ToList();
                CategoryList.Items.Add($"{cat.id}-{cat.category_name}");

            }

        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            if (NewCategoryText.Text != "")
            {
                FridgeManagementDBEntities db = new FridgeManagementDBEntities();
                Category categoryObject = new Category()
                {
                    category_name = NewCategoryText.Text
                };
                db.Category.Add(categoryObject);
                db.SaveChanges();
                UpdateCategoryList();
                NewCategoryText.Clear();

            }
        }

        private void RemoveCategory_Click(object sender, RoutedEventArgs e)
        {
            if (CategoryList.SelectedItem != null)
            {
                FridgeManagementDBEntities db = new FridgeManagementDBEntities();
                var selected = CategoryList.SelectedItem.ToString().Split('-')[1];
                IQueryable<Category> catToRemove = db.Category.Where(ct => ct.category_name == selected);
                db.Category.RemoveRange(catToRemove);
                db.SaveChanges();
                UpdateCategoryList();

            }
        }
    }
}
