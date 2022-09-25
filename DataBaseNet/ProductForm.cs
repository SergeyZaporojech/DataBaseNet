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

        // Sorts ListViewItem objects by index.
        private class ListViewIndexComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }
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
                    // item.Name = p.Id.ToString();
                    item.Tag = p;
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

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            var product = lvProducts.Items[0].Selected;
            //foreach (var item in product)
            //{
            //    MessageBox.Show($"{item.GetType}");
            //}
            
            //MessageBox.Show($"{product.ContainsKey}");


        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            //var select = lvProducts.SelectedItems.Contains;
            //ListViewItem item = new ListViewItem();
            
            //MessageBox.Show(select);
           
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var listSelect = lvProducts.SelectedItems;
            if (listSelect.Count>0)
            {
                var item = listSelect[0];
                var p = (Product)item.Tag;
                MessageBox.Show("Product info: " + p.Id.ToString());
            }
            else
            {
            MessageBox.Show(listSelect.Count.ToString());

            }
        }

        private void lvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listSelect = lvProducts.SelectedItems;
            if (listSelect.Count > 0)
            {
                var item = listSelect[0];
                var p = (Product)item.Tag;
                MessageBox.Show("Product info: " + p.Id.ToString());

            }

        }
        // Starts the drag-and-drop operation when an item is dragged.
        private void lvProducts_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvProducts.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        // Sets the target drop effect.
        private void lvProducts_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        // Moves the insertion mark as the item is dragged.
        private void lvProducts_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            Point targetPoint =
                lvProducts.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = lvProducts.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = lvProducts.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    lvProducts.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    lvProducts.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            lvProducts.InsertionMark.Index = targetIndex;
        }

        // Removes the insertion mark when the mouse leaves the control.
        private void lvProducts_DragLeave(object sender, EventArgs e)
        {
            lvProducts.InsertionMark.Index = -1;
        }

        // Moves the item to the location of the insertion mark.
        private void lvProducts_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = lvProducts.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            }

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (lvProducts.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values. 
            lvProducts.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            lvProducts.Items.Remove(draggedItem);
        }

    }
}
