using SchoolBL;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms.UsersForms
{
    public partial class frmUpdateUser : Form
    {
        private Users _users;
        private bool _isUsertUpdated;
        UsersBL usersBL = new UsersBL();

        public Users Users
        {
            set { _users = value; }
        }
        public frmUpdateUser()
        {
            InitializeComponent();
            
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            userNameLabel1.Text = _users.UserName;
            administratorCheckBox.Checked = _users.Administrator;
        }

        private void userNameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void UpdateUser()
        {
            _users.Administrator = administratorCheckBox.Checked;


            _isUsertUpdated = usersBL.UpdateUser(_users);
                if (_isUsertUpdated == true)
                {
                    MessageBox.Show("User is updated");
                    this.Close();
                }
            
        }
    }
}
