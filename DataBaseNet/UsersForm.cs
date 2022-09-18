using DataBaseNet.Data;
using DataBaseNet.Data.Entittes;

namespace DataBaseNet
{
    public partial class UsersForm : System.Windows.Forms.Form
    {

        MyDataContext context = new MyDataContext();
        public UsersForm()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            var users = context.Users                     
                    .AsQueryable();

            foreach (var user in users)
            {           
                object[] row = { 
                    user.Id,
                    user.LastName,
                    user.FirstName,
                    user.Phone,
                    user.Email};
                dgvUsers.Rows.Add(row);
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm dlg = new AddUserForm();
           
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                User user = new User()
                {
                    LastName = dlg.LastName,
                    FirstName = dlg.FirstName,
                    Phone = dlg.Phone,
                    Email = dlg.Email
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}