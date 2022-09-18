using DataBaseNet.Data;
using DataBaseNet.Data.Entittes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseNet
{
    public partial class ProductForm : Form
    {
        MyDataContext myData = new MyDataContext();
        public ProductForm()
        {
            InitializeComponent();
            Load();            
        }

        public void Load()
        {
            try
            {
                lvProducts.Clear();
                lvProducts.LargeImageList = new ImageList();
                lvProducts.LargeImageList.ImageSize = new Size(64, 64);
                foreach (var p in myData.Products
                    .Include(x => x.ProductImages)
                    .ToList())
                {
                    var pImage = p.ProductImages.OrderBy(x => x.Priority).FirstOrDefault();
                    string id = "0";
                    string image = "no-image.jpg";

                    if (pImage != null)
                    {
                        image = pImage.Name;
                        id = pImage.Id.ToString();
                    }
                    lvProducts.LargeImageList.Images.Add(
                       id,
                       Image.FromFile($"Images/{image}"));

                    ListViewItem item = new ListViewItem();
                    item.Text = $"{p.Name}\r\n{p.Price}";
                    item.ImageKey = $"{id}";
                    lvProducts.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm dlg = new UsersForm();
            dlg.ShowDialog() ;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm dlg = new AddProductForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {                
                Product product = new Product()
                {
                    Name = dlg.Name,
                    Price = dlg.Price,
                    DescriptionPrice = dlg.Description
                };
                myData.Products.Add(product);
                myData.SaveChanges();
                Load();
            }
        }
    }
}
