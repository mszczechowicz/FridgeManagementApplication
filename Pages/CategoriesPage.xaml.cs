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
        /// Adding new category Method
        /// </summary>
        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            if (NewCategoryText.Text != "")
            {
                FridgeMgDBEntities db = new FridgeMgDBEntities();
                Category categoryObject = new Category()
                {
                    category_name = NewCategoryText.Text
                };
                bool catMatch = db.Category.Any(ct => ct.category_name == NewCategoryText.Text);

                if (catMatch)
                {
                    MessageBox.Show("Category already exist.");
                }
                else
                {
                    db.Category.Add(categoryObject);
                    db.SaveChanges();
                    UpdateCategoryList();
                    NewCategoryText.Clear();
                }
            }
        }

        /// <summary>
        /// Remove Category Method
        /// </summary>
        private void RemoveCategory_Click(object sender, RoutedEventArgs e)
        {
            if (CategoryList.SelectedItem != null)
            {
                FridgeMgDBEntities db = new FridgeMgDBEntities();

                var selected = CategoryList.SelectedItem.ToString().Split('-')[1];
                IQueryable<Category> catToRemove = db.Category.Where(ct => ct.category_name == selected);
                //TODO CANT REMOVE CATEGORY USAGE BY PRODUCT

                if (MessageBox.Show("Are you sure want to remove category?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No) { }

                else
                {
                    try
                    {
                        db.Category.RemoveRange(catToRemove);
                        db.SaveChanges();
                        UpdateCategoryList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Category is in use. \r\nBefore deleting a category, please remove the products that contain it.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }
    }
}
