
using School.Forms;
using SchoolBL;
using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class frmLogIn : Form
    {
        private bool _isUsernameValid;
        private bool _isPasswordValid;
        private bool _isUserValid ;
        private bool _mouseDown;
        private bool _isAdmin;
        private string _logInUsername;
        private string _dbUsername;
        private string _logInPassword;
        private string _dbPassword;
        private Point _offset;
        Users users = new Users();
        UsersBL usersBL = new UsersBL();
        


        public frmLogIn()
        {
            InitializeComponent();
            Init();
            usersBindingSource.DataSource = users;
            
         


        }

        private void Init()
        {
            users.UserName = "Username";
            users.UserPassword = "Password";
            lblLogIn.Text = "Please Log In";
        
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region frmLogInMovement
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
           

           this.Close();
        }

        private void userPasswordTextBox_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
            userPasswordTextBox.PasswordChar = '*';
          
        }

        private void userNameTextBox_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ValidateAll();
             OpenMain();
        }  




        

        private void ValidateAll()
        { 
            _logInUsername = users.UserName;
            _dbUsername = usersBL.GetUserByUsername(users.UserName).UserName;
           _logInPassword = users.UserPassword;
           _dbPassword = usersBL.GetUserByUsername(users.UserName).UserPassword;

            _isAdmin = usersBL.GetUserByUsername(users.UserName).Administrator;
           _isUsernameValid = ValidateUsername(_logInUsername, _dbUsername);
           _isPasswordValid = ValidatePassword(_logInPassword, _dbPassword);
             _isUserValid = usersBL.ValidateUser(_isUsernameValid, _isPasswordValid);
         }
          
          
           
      

        public bool ValidateUsername(string LogInUsername, string DbUsername)
        {
            bool UsernameIsCorrect = usersBL.ValidateUsernameLogIn(LogInUsername, DbUsername);

            
            if (UsernameIsCorrect==false)
            {
               
                errorProvider1.SetError(userNameTextBox, "Incorect username");
              

            }

            return UsernameIsCorrect;


        }
        
        public bool ValidatePassword(string SignInPassword, string DbPassword)
        {
            bool PasswordIsCorrect = usersBL.ValidatePassword(SignInPassword, DbPassword);
           
           if (PasswordIsCorrect==false)
            {
               
                errorProvider1.SetError(userPasswordTextBox, "Incorect password");
                
            }
            return PasswordIsCorrect;
        }
       
        public bool ValidateUser(bool usernameIsValid, bool passwordIsValid)
        {
            bool IsUserValid = usersBL.ValidateUser(usernameIsValid, passwordIsValid);
            return IsUserValid;
           

        }
        private void lblSignIn_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp1 = new frmSignUp();
            frmSignUp1.Show();
        }
       
        public void OpenMain()
        {
            frmMain main = new frmMain();
            if(_isUserValid==true)
            {
                
                main.IsAdministrator = _isAdmin;
               main.Show();
                 this.Hide();
               
            }
        }

       

       
       
    }
}
