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

            FridgeMgDBEntities db = new FridgeMgDBEntities();

            //IQueryable<Users> Users = db.Users.Where(el=>el.user_name == GLOBALNY.WYBRANEIDUSERA )

            //IQueryable<Users> usrs = db.Users;

            var items = from i in db.Product
                        select i;


            foreach (var it in items)
            {               
               //FridgeList.ItemsSource = db.Product.ToList();
                FridgeList.Items.Add($"{it.id}-{it.product_name}-{it.quantity_product}-{it.Category.category_name}");
            }
            QuantityToRemove.Clear();
        }

        private void UpdateCategoryList()
        {
            CategoryList.Items.Clear();

            FridgeMgDBEntities db = new FridgeMgDBEntities();

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
                 FridgeMgDBEntities db = new FridgeMgDBEntities();
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
               

                // ADDING RAPORT 

                Raports raport = new Raports()
                {

                    id_user = SelectedHolder.SelectedHolderId,
                    product_name_rap =productObject.product_name ,
                    raport_quantity = Int32.Parse(QuantityText.Text),
                    add_remove = "ADDED",
                    action_time = DateTime.Now
                };
                db.Raports.Add(raport);
                db.SaveChanges();
                NewNameText.Clear();
                QuantityText.Clear();


            }
        }

        //ADDDING RAPORT 2
        private  int findProductID(string productname)
        {
            FridgeMgDBEntities db = new FridgeMgDBEntities();
            IQueryable<Product> product = db.Product.Where(p=> p.product_name ==productname );

            return product.First().id;
        }



        private string findCategory(int id)
        {
            FridgeMgDBEntities db = new FridgeMgDBEntities();
            IQueryable<Category> category = db.Category.Where(el => el.id == id);
            return category.First().category_name;
        }
        private int findCategoryID(string category)
        {
            FridgeMgDBEntities db = new FridgeMgDBEntities();
            IQueryable<Category> categories = db.Category.Where(el => el.category_name == category);
            return categories.First().id;
        }
        //TODO ADD SUMMARIES 
        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (FridgeList.SelectedItem != null && QuantityToRemove.Text != "")
            {
                FridgeMgDBEntities db = new FridgeMgDBEntities();

                var selectedItem = FridgeList.SelectedItem.ToString().Split('-');

                var selectedProduct = selectedItem[1];

                IQueryable<Product> productUpdate = db.Product.Where(pr => pr.product_name == selectedProduct);
                var prod = productUpdate.First();

                int quant = Int32.Parse(QuantityToRemove.Text);

                int selectquant = Int32.Parse(selectedItem[2]);
                int result = selectquant - quant;
                if (result == 0)
                {
                    Raports raport = new Raports()
                    {

                        id_user = SelectedHolder.SelectedHolderId,
                        product_name_rap = prod.product_name ,
                        raport_quantity = quant,
                        add_remove = "REMOVE",
                        action_time = DateTime.Now
                    };

                    db.SaveChanges();


                    db.Product.RemoveRange(productUpdate);
                    db.SaveChanges();
                    UpdateFridge();
                }
                else if (result < 0)
                {
                    MessageBox.Show("Invalid value");
                }
                else
                {
                    Raports raport = new Raports()
                    {

                        id_user = SelectedHolder.SelectedHolderId,
                        product_name_rap = prod.product_name,
                        raport_quantity = quant,
                        add_remove = "REMOVE",
                        action_time = DateTime.Now
                    };

                    prod.quantity_product = result;
                    db.SaveChanges();



                }
                db.SaveChanges();
                UpdateFridge();

                //REMOVEING RAPORT

               
            }
        }    
       


      

        //TODO ALERTS ARE U SURE, ERRORS
    }
}
