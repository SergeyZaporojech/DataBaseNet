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
    public partial class AddProductForm : Form
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Description = txtDiscription.Text;
            Price = Convert.ToDecimal(txtPrice.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
