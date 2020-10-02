using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Repository;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Controller
{
    public class UserController
    {
        public static string login(string email, string password)
        {
            string error = "";
            if (email == "")
            {
                error = "Please insert your email";
            }
            else if (password == "")
            {
                error = "Please insert yout password";
            }
            else if (UserRepo.get(email, password) == null)
            {
                error = "You are not a member please register first";
            }
            else if (!UserRepo.getUserPassword(email, password).Equals(password))
            {
                error = "Your password is wrong";
            }
            else if (UserRepo.getUserStatus(email, password).Equals("blocked"))
            {
                error = "You're Banned";
            }
            return error;
        }
        public static string register(string email, string name, string password, string confirmPassword, string gender)
        {
            string error = "";
            if (email == "")
            {
                error= "Please insert your email!";
            }
            else if (!UserHandler.tryRegister(email))
            {
                error = "The email must be unique!";
            }
            else if (name == "")
            {
                error = "Please insert your name!";
            }
            else if (password == "")
            {
                error = "Please insert password field!";
            }
            else if (confirmPassword == "")
            {
                error = "Please insert confirm password field!";
            }
            else if (password != confirmPassword)
            {
                error = "The password and confirm password must be same!";
            }
            else if (gender == "")
            {
                error = "Please choose your gender!";
            }
            return error;
        }
        public static string updateUser(String ID, String Role, String Status, int CurrentUserID)
        {
            string error = "";
            int IDs=0;
            bool flag = true;
            try
            {
                IDs = int.Parse(ID);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    flag = false;
                    error = "Input ID must be a number";
                }
            }
            if (flag)
            {
                if (ID == "")
                {
                    error = "Please insert user ID";
                }
                else if (Role == "")
                {
                    error = "Please choose one role";
                }
                else if (Status == "")
                {
                    error = "Please choose one status";
                }
                else if (IDs == CurrentUserID)
                {
                    error = "You cannot change your current role and status";
                }
                else if (!UserHandler.checkIDIsValid(IDs))
                {
                    error = "ID is not valid";
                }
            }
            return error;
        }
        public static string updateProfile(int ID, String Email, String Name, String Gender)
        {
            string error = "";
            if (Email == "")
            {
                error = "Please insert your email!";
            }
            else if (!UserHandler.tryUpdate(ID, Email))
            {
                error = "The email must be unique!";
            }
            else if (Name == "")
            {
                error = "Please insert your name!";
            }
            else if (Gender == "")
            {
                error = "Please choose your gender!";
            }
            return error;
        }
        public static string changePassword(String NewPassword, String OldPassword, String ConfirmPassword, String LastPassword)
        {
            string error = "";
            if (NewPassword.Length <= 5 || OldPassword.Length <= 5 || ConfirmPassword.Length <= 5)
            {
                error = "Password invalid!";
            }
            else if (OldPassword != LastPassword)
            {
                error = "Old pasword is wrong!";
            }
            else if (NewPassword != ConfirmPassword)
            {
                error = "New password and confirm password must be same!";
            }
            return error;
        }
    }
}