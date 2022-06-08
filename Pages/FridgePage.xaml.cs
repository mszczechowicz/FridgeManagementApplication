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
    /// Logika interakcji dla klasy FridgePage.xaml
    /// </summary>
    public partial class FridgePage : Page
    {
        public FridgePage()
        {
            InitializeComponent();
            UpdateFridge();
            UpdateCategoryList();
        }

        private void UpdateFridge()
        {
            FridgeList.Items.Clear();

            FridgeManagementDBEntities db = new FridgeManagementDBEntities();

            //IQueryable<Users> Users = db.Users.Where(el=>el.user_name == GLOBALNY.WYBRANEIDUSERA )

            //IQueryable<Users> usrs = db.Users;

            var items = from i in db.Product
                        select i;


            foreach (var it in items)
            {               
                //UsersList.ItemsSource = db.Users.ToList();
                FridgeList.Items.Add($"{it.id}-{it.product_name}-{it.quantity_product}-{it.Category.category_name}");
            }

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









        private void InsertToFridge_Click(object sender, RoutedEventArgs e)
        {
            if (NewNameText.Text != "" && QuantityText.Text != "" && CategoryList.SelectedItem != null)               
            {
                FridgeManagementDBEntities db = new FridgeManagementDBEntities();
               // int id_cat = CategoryList.SelectedItem.ToString()

                var selectedCat = CategoryList.SelectedItem.ToString().Split('-')[1];
                IQueryable<Category> cat = db.Category.Where(el => el.category_name == selectedCat);





                Product productObject = new Product()
                {
                    product_name = NewNameText.Text,
                    quantity_product = Int32.Parse(QuantityText.Text),
                   id_category = findCategoryID(selectedCat)
                };
                db.Product.Add(productObject);
                db.SaveChanges();
                UpdateFridge();
                NewNameText.Clear();
                QuantityText.Clear();

            }
        }
        private string findCategory(long id)
        {
            FridgeManagementDBEntities db = new FridgeManagementDBEntities();
            IQueryable<Category> category = db.Category.Where(el => el.id == id);
            return category.First().category_name;
        }
        private int findCategoryID(string category)
        {
            FridgeManagementDBEntities db = new FridgeManagementDBEntities();
            IQueryable<Category> categories = db.Category.Where(el => el.category_name == category);
            return categories.First().id;
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (FridgeList.SelectedItem != null && QuantityToRemove.Text != "")
            {
                FridgeManagementDBEntities db = new FridgeManagementDBEntities();
                var selectedItem = FridgeList.SelectedItem.ToString().Split('-');
                var selectedProduct = selectedItem[1];
                var selectquant = selectedProduct[2];
                IQueryable<Product> productUpdate = db.Product.Where(pr => pr.product_name == selectedProduct);
                int quant = Int32.Parse(QuantityToRemove.Text);

                int result = selectquant - quant;
                if (result == 0)
                {
                    db.Product.RemoveRange(productUpdate);
                    db.SaveChanges();
                    UpdateFridge();
                }
                else if (result < 0)
                    MessageBox.Show("Invalid value");
                else
                {
                 // IQueryable<Product> productvaluechange = db.Product.Where(pr => pr.product_name == selectedProduct).ToList().ForEach(pr => pr.quantity_product = quant);

                }
                db.SaveChanges();
                UpdateFridge();

            }
        }
       


      

        //TODO ALERTS ARE U SURE, ERRORS
    }
}
