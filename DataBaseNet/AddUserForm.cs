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
    public partial class AddUserForm : System.Windows.Forms.Form
    {
        
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LastName = txtLastName.Text;
            FirstName = txtFirstName.Text;
            Phone = txtPhone.Text;
            Email = txtEmail.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
