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
    public partial class frmUsers : Form
    {
        public List<Users> users = new List<Users>();
        public UsersBL usersBL = new UsersBL();
        private string _filter;

        public frmUsers()
        {
            InitializeComponent();
            Init();
           
        }

        private void Init()
        {
            usersMetroGrid.Columns[0].Visible = false;
            usersMetroGrid.Columns[1].HeaderText = "Username";
            usersMetroGrid.Columns[2].HeaderText = "Password";
            usersMetroGrid.Columns[3].HeaderText = "E-Mail";
            LoadUserGrid();
            
        }

        private void LoadUserGrid()
        {
            usersMetroGrid.DataSource = usersBL.SelectAllUsers();
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usersMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlUserList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUserGrid();
        }

        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            SearchUsers();
        }

        private void SearchUsers()
        {
            // LoadUserGrid();
            users = usersBL.SelectAllUsers();
            _filter = tbSearch.Text;

            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    LoadUserGrid();
                    break;
                case 1:
                    _filter = tbSearch.Text;
                    usersMetroGrid.DataSource = usersBL.FilterByUserName(users, _filter);
                    break;
               

            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbDeleteSutudent_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void DeleteUser()
        { 
            int a = SelectUserFromDataGridView().UsersID;
            if (a == 0)
            {
                MessageBox.Show("User list is empty");

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete User", "Delete User?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {




                    bool StudentIsDeleted = usersBL.DeleteUser(SelectUserFromDataGridView().UsersID);
                  
                    LoadUserGrid();
                    if (StudentIsDeleted == true)
                    {

                        MessageBox.Show("User is deleted");
                    }
                    else
                    {
                        MessageBox.Show("Ops something went wrong");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

       
        public Users SelectUserFromDataGridView()
        {

            Users user = new Users();
            try
            {
                user = usersMetroGrid.SelectedRows[0].DataBoundItem as Users;
            }
            catch
            {
                user.UsersID = 0;
                user.UserName = null;
                user.UserEmail = null;
                user.UserPassword = null;
              

            }

            return user;

        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        public void AddUser()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmSignUp")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmSignUp frmSignUp = new frmSignUp();

                frmSignUp.ShowDialog();
                frmSignUp.BringToFront();
                // _isTeacherUpdated = updateTeacher.IsTeacherUpdated;

                LoadUserGrid();

            }
        }

        private void pbUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
        public void UpdateUser()
        {
            bool IsOpen = false;
            users = usersBL.SelectAllUsers();
            if (users.Count == 0)
            {
                MessageBox.Show("Subject list is empty");

            }
            else
            {


                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmUpdateUser")
                    {
                        IsOpen = true;
                        form.BringToFront();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    frmUpdateUser frmUpdateUser = new frmUpdateUser();
                    frmUpdateUser.Users = SelectUserFromDataGridView();
                    frmUpdateUser.ShowDialog();
                    frmUpdateUser.BringToFront();


                    LoadUserGrid();

                }
            }
        }
    }
}
