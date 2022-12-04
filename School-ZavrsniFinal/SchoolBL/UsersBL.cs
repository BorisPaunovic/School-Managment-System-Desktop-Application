using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL
{
    public class UsersBL
    {
        public  bool DeleteUser(int UserId)
        {
            bool UserIsDeleted = UsersDAL.DeleteUser(UserId);
            return UserIsDeleted;
        }
        public  List<Users> SelectAllUsers()
        {
           List<Users> usersList = new List<Users>();
            usersList = SchoolDAL.UsersDAL.SelectAllUsers();
            return usersList;


        }

        public Users GetUserByUsername(string users)
        {
            Users user = new Users();
             user= UsersDAL.GetUserByUsername(users) ;
            return user;

        }
        public bool InsertUser(Users user)
        {

            bool success = UsersDAL.InsertUser(user);
            return success;


        }

        public List<Users> FilterByUserName(List<Users> users1, string TextBox)
        {

            List<Users> users = new List<Users>();
            foreach (var element in users1)
            {
                if (element.UserName.ToLower().Contains(TextBox.ToLower()) == true)
                {
                    users.Add(element);
                }


            }
            return users;

        }

        public  bool UpdateUser(Users users)
        {
           bool UserIsUpdated = UsersDAL.UpdateUser(users);
            return UserIsUpdated;
        }

        public bool ValidatePassword(string SignInPassword, string DbPassword)
        {
            bool PasswordIsCorrect = true;
            if (SignInPassword == DbPassword)
            {
                PasswordIsCorrect = true;
               
            }
            else if (SignInPassword != DbPassword || String.IsNullOrEmpty(DbPassword) == true)
            {
                PasswordIsCorrect = false;
                
            }
            return PasswordIsCorrect;

        }
        public bool ValidateUser(bool usernameIsValid, bool passwordIsValid)
        {
            bool IsUserValid = false;
            if (usernameIsValid == true && passwordIsValid == true)
            {
                IsUserValid = true;
               
            }
           
            return IsUserValid;

        }
        public bool ValidateUserSignUp(bool usernameIsValid, bool emailIsValid, bool passwordIsvalid)
        {
            bool ContainsUsername = false;

            if (usernameIsValid == true && emailIsValid == true && passwordIsvalid == true)
            {
                ContainsUsername = true;

            }
            return ContainsUsername;
        }
        public bool ValidateUsernameLogIn(string DbUsername, string usernametb)
        {
            bool UsernameIsCorrect = false;
            if (String.IsNullOrEmpty(usernametb)==false && usernametb==DbUsername)

            {
                UsernameIsCorrect = true;


            }

            return UsernameIsCorrect;
        }
        public bool ValidateUsernameSingUp(string DbUsername,string LogInUsername)
        {
            bool UsernameIsCorrect = false;

           
             if ( String.IsNullOrEmpty(LogInUsername)==false &&  LogInUsername != DbUsername  && LogInUsername.Length>5)
            {
                UsernameIsCorrect = true;


            }

            return UsernameIsCorrect;


        }
        public bool ValidatePasswordSingUp(string password, string repeatPassword)
        {
            bool PasswordIsValid = false;
            if (String.IsNullOrEmpty(password) == false && String.IsNullOrEmpty(repeatPassword) == false && password == repeatPassword && password.Length > 5)
            {
                PasswordIsValid = true;

            }

            return PasswordIsValid;
        }
        public bool ValidateEmailSingUp(string UserEmail, string dbEmail)
        {
            bool Emaililisvalid = false;

            if (String.IsNullOrEmpty(dbEmail) && UserEmail.Contains("@"))
            {
                Emaililisvalid = true;

            }
            else if (String.IsNullOrEmpty(dbEmail) == false)
            {
                if (UserEmail == dbEmail)
                { 
                    Emaililisvalid = false; 
                } 
            }
            return Emaililisvalid;
        }

                   

               

                


           

            


            









       


    }
}
