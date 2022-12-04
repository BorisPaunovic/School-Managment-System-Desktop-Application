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

namespace School.Forms
{
    public partial class frmSignUp : Form
    {
        private bool _success;
        public bool _usernameIsValid;
        private bool _emailIsValid;
        private bool _passwordIsvalid;
        private bool _IsUserValid ;
        private string _repeatPassword;
        private bool _mouseDown;
        private Point _offset;
        private string _username;
        private string _formEmail;
        private string _dbEmail;
        private string _dbUsername;
        Users users = new Users();
     
       
        UsersBL usersBL = new UsersBL();
        public frmSignUp()
        {
            InitializeComponent();
            Init();
           
        }

        private void Init()
        {
            users.UserName = "Username";
            userNameTextBox1.Text = "Username";
            lblSignIn.Text = "Please Sign In";
            lblClose.Text = "X";
            users.UserEmail = "E-Mail";
            users.UserPassword = "Password";
            tbRepeatPassword.Text = "Repeat Password";
            btnSignUp.Enabled = true;
            usersBindingSource.DataSource = users;
        
        }
        #region SignUpMovement
        private void pnlMovement_MouseMove(object sender, MouseEventArgs e)
        {

            if (_mouseDown == true)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _offset.X, point.Y - _offset.Y);
            }
        }

        private void pnlMovement_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _mouseDown = true;
            pnlMovement.BackColor = Color.DarkCyan;
        }

        private void pnlMovement_MouseEnter(object sender, EventArgs e)
        {
            pnlMovement.BackColor = Color.Cyan;
        }

        private void pnlMovement_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            pnlMovement.BackColor = Color.White;
        }

        private void pnlMovement_MouseLeave(object sender, EventArgs e)
        {
            pnlMovement.BackColor = Color.White;
        }
        #endregion


       

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void userNameTextBox1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
           
        }



        

        private void btnSignUp_Click(object sender, EventArgs e)
        { 
            ValidateUser();
            SaveUser(users);
        }
           

          
           

           
          


        

        private void ValidateUser()
        { 
            _username = users.UserName;
             _formEmail = userEmailTextBox1.Text;
             _dbEmail = usersBL.GetUserByUsername(_username).UserEmail;
             _dbUsername = usersBL.GetUserByUsername(users.UserName).UserName;
            _repeatPassword = tbRepeatPassword.Text;
            _usernameIsValid = usersBL.ValidateUsernameSingUp(_dbUsername, userNameTextBox1.Text);
            _passwordIsvalid = usersBL.ValidatePassword(users.UserPassword, _repeatPassword);
            _emailIsValid = usersBL.ValidateEmailSingUp(_formEmail, _dbEmail);
            _IsUserValid = usersBL.ValidateUserSignUp(_usernameIsValid,  _emailIsValid  , _passwordIsvalid);
            if(_usernameIsValid == false)
            {
               errorProvider1.SetError(userNameTextBox1, "Invalid username");
            }
            if (_passwordIsvalid == false)
            {
                errorProvider1.SetError(userPasswordTextBox1, "Invalid Password");
                errorProvider1.SetError(tbRepeatPassword, "Invalid Password");
            }
            if(_emailIsValid == false)
            {
                errorProvider1.SetError(userEmailTextBox1, "Email is invalid");
            }

        }

        private void userEmailTextBox1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
         

        }

        private void userPasswordTextBox1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
          
            userPasswordTextBox1.PasswordChar = '*';
           
        }

        private void tbRepeatPassword_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
            tbRepeatPassword.PasswordChar = '*';
            
        }
      
        public void SaveUser(Users user)
        {
            if(_IsUserValid==true)
            {
                _success = usersBL.InsertUser(user);
                if (_success == true)
                {
                    MessageBox.Show("You have created your account successfully");
                    this.Close();
                }
                else if (_success==false)
                {
                    MessageBox.Show("Ooops something went wrong");
                }


            }
        }
    }
}
