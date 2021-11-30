using LogementImobilier.BLL;
using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform
{
    public partial class FrmModify : Form
    {
        List<User> users;
        UserManager manager;


        public FrmModify()
        {
            users = new List<User>();
            manager = new UserManager();
            InitializeComponent();
        }

        private void FrmModify_Load(object sender, EventArgs e)
        {
            listUser.Items.Clear();
            users = manager.GetAllUsers();
            if (users.Count != 0)
                foreach (var us in users)
                {
                    var item = new ListViewItem(new string[] { us.Id, us.Name, us.Password });
                    item.Tag = us;
                    listUser.Items.Add(item);
                    Program.user = us;
                }

        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUser.SelectedItems.Count == 0)
                return;
            var user = listUser.SelectedItems[0].Tag as User;
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (listUser.SelectedItems.Count == 0)
                return;
            User user = new User();
            user = listUser.SelectedItems[0].Tag as User;
            tbId.Text = user.Id;
            tbfullname.Text = user.Name;
            tbpassword.Text = user.Password;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (listUser.SelectedItems.Count == 0)
                return;
            User user = new User();
            user = listUser.SelectedItems[0].Tag as User;
            manager.DeleteUser(user);
            listUser.SelectedItems.Clear();
        }
    }
}
