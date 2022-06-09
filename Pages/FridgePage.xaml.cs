using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        /// <summary>
        /// Refresh Fridge ListBox Method
        /// </summary>
        private void UpdateFridge()
        {
            FridgeList.Items.Clear();
            FridgeMgDBEntities db = new FridgeMgDBEntities();

            IQueryable<Product> items = db.Product;
            foreach (var it in items)
            {                             
                FridgeList.Items.Add($"{it.id}-{it.product_name}-{it.quantity_product}-{it.Category.category_name}");
            }
            QuantityToRemove.Clear();
        }
        /// <summary>
        /// Refresh Category ListBox Method
        /// </summary>
        private void UpdateCategoryList()
        {
            CategoryList.Items.Clear();
            FridgeMgDBEntities db = new FridgeMgDBEntities();

            IQueryable<Category> cats = db.Category;
            foreach (var cat in cats)
            {            
                CategoryList.Items.Add($"{cat.id}-{cat.category_name}");
            }
        }
      
        /// <summary>
        /// Adding product to fridge Method
        /// </summary>
        private void InsertToFridge_Click(object sender, RoutedEventArgs e)
        {
            if (NewNameText.Text != "" && QuantityText.Text != "" && CategoryList.SelectedItem != null)               
            {
                 FridgeMgDBEntities db = new FridgeMgDBEntities();       

                var selectedCat = CategoryList.SelectedItem.ToString().Split('-')[1];
                IQueryable<Category> cat = db.Category.Where(el => el.category_name == selectedCat);

                int quantity_to_add = Int32.Parse(QuantityText.Text);

                if (quantity_to_add <= 0)
                {
                    MessageBox.Show("Invalid quantity value");
                }
                else
                {
                    Product productObject = new Product()
                    {
                        product_name = NewNameText.Text,
                        quantity_product = Int32.Parse(QuantityText.Text),
                        id_category = FindCategoryID(selectedCat)
                    };
                    db.Product.Add(productObject);
                    db.SaveChanges();
                    UpdateFridge();

                    /// <summary>
                    /// Adding raport
                    /// </summary>
                    Raports raport = new Raports()
                    {
                        id_user = SelectedHolder.SelectedHolderId,
                        product_name_rap = productObject.product_name,
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
        }      

        /// <summary>
        /// Removing product from fridge Method
        /// </summary>
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
                    /// <summary>
                    /// Adding raport
                    /// </summary>
                    Raports raport = new Raports()
                    {
                        id_user = SelectedHolder.SelectedHolderId,
                        product_name_rap = selectedProduct ,
                        raport_quantity = quant,
                        add_remove = "REMOVE",
                        action_time = DateTime.Now
                    };

                    db.Product.RemoveRange(productUpdate);
                    db.Raports.Add(raport);
                    db.SaveChanges();
                    UpdateFridge();
                }
                else if (result < 0)
                {
                    MessageBox.Show("Invalid value");
                }
                else
                {
                    /// <summary>
                    /// Adding raport
                    /// </summary>
                    Raports raport = new Raports()
                    {
                        id_user = SelectedHolder.SelectedHolderId,
                        product_name_rap = selectedProduct,
                        raport_quantity = quant,
                        add_remove = "REMOVE",
                        action_time = DateTime.Now
                    };

                    prod.quantity_product = result;

                    db.Raports.Add(raport);
                    db.SaveChanges();
                    UpdateFridge();
                }
                db.SaveChanges();
                UpdateFridge();              
            }
        }

        /// <summary>
        /// Find category ID by category name Method
        /// </summary>
        private int FindCategoryID(string category)
        {
            FridgeMgDBEntities db = new FridgeMgDBEntities();
            IQueryable<Category> categories = db.Category.Where(el => el.category_name == category);
            return categories.First().id;
        }

        /// <summary>
        /// Prevent Text Input Method
        /// </summary>
        private void PreventTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
