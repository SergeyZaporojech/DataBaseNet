using DataBaseNet.Data;
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
    public partial class EditProductForm : Form
    {
        private class ListViewIndexComparer : System.Collections.IComparer   //клас для порівняння
        {
            public int Compare(object x, object y)
            {
                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }

        MyDataContext myData = new MyDataContext();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> ListImages { get; set; } = new List<string>();
        public EditProductForm()
        {
            InitializeComponent();
            lvImages.LargeImageList = new ImageList();
            lvImages.LargeImageList.ImageSize = new Size(64, 64);
            lvImages.MultiSelect = false;                                      // настройки для перетягуванння
            lvImages.ListViewItemSorter = new ListViewIndexComparer();
            // Initialize the insertion mark.
            lvImages.InsertionMark.Color = Color.Green;                        // настройки для перетягуванння
            lvImages.AllowDrop = true;                                         // настройки для перетягуванння         
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            var prod = myData.Products
                          .AsQueryable();
            foreach (var item in prod)
            {
                if (Id == item.Id)
                {
                    txtName.Text = item.Name;
                    txtPrice.Text = item.Price.ToString();
                    txtDiscription.Text = item.DescriptionPrice;
                }
            }
            var products = myData.Products
                .Include(x => x.ProductImages);            
            
            foreach (var item in products)
            {
                foreach (var images in item.ProductImages)
                {
                    if (images.ProductId == Id)
                    {
                        string key = Guid.NewGuid().ToString();
                        ListViewItem lv = new ListViewItem();
                        lv.Tag = $"Images\\{images.Name}";
                        lv.Text = Path.GetFileName(images.Name);
                        lv.ImageKey = key;
                        lvImages.LargeImageList.Images.Add(key, Image.FromFile($"Images/{images.Name}"));
                        lvImages.Items.Add(lv);
                    }                   
                }                
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Price = Decimal.Parse(txtPrice.Text);
            Description = txtDiscription.Text;

            foreach (ListViewItem item in lvImages.Items)
            {
                ListImages.Add(item.Tag.ToString());
            }
            DialogResult = DialogResult.OK;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string key = Guid.NewGuid().ToString();
                ListViewItem item = new ListViewItem();
                item.Tag = dlg.FileName;
                item.Text = Path.GetFileName(dlg.FileName);
                item.ImageKey = key;
                lvImages.LargeImageList.Images.Add(key, Image.FromFile(dlg.FileName));
                lvImages.Items.Add(item);
            }
        }

        private void lvImages_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvImages.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvImages_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void lvImages_DragLeave(object sender, EventArgs e)
        {
            lvImages.InsertionMark.Index = -1;

        }

        private void lvImages_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            Point targetPoint =
                lvImages.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = lvImages.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = lvImages.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    lvImages.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    lvImages.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            lvImages.InsertionMark.Index = targetIndex;
        }

        private void lvImages_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = lvImages.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            }

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (lvImages.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values. 
            lvImages.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            lvImages.Items.Remove(draggedItem);
        }
    }
}
