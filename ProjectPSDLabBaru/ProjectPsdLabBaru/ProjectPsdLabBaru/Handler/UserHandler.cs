using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Repository;
using ProjectPsdLabBaru.Factory;
using ProjectPsdLabBaru.Constant;

namespace ProjectPsdLabBaru.Handler
{
    public class UserHandler
    {
        public static User get(String email, String password)
        {
            return UserRepo.get(email, password);
        }
        public static int getLastUserID()
        {
            return UserRepo.getLastUserID();
        }
        public static Boolean tryRegister(String email)
        {
            User user = UserRepo.get(email);
            if (user == null) return true;
            else return false;
        }
        public static Boolean tryUpdate(int ID, String email)
        {
            User user = UserRepo.getAnotherUser(ID, email);
            if (user == null) return true;
            else return false;
        }
        public static void addUser(String email, String name, String password, String gender)
        {
            UserRepo.addUser(UserFactory.createUser(email, name, password, gender));
        }
        public static List<UserInformation> getUserCustomView()
        {
            return UserRepo.getUserCustomView();
        }
        public static Boolean checkIDIsValid(int ID)
        {
            User user = UserRepo.get(ID);
            if (user == null) return false;
            else return true;
        }
        public static void updateUser(int ID, String Role, String Status)
        {
            UserRepo.updateUser(ID, Role, Status);
        }
        public static void updateProfile(int ID, String Email, String Name, String Gender)
        {
            UserRepo.updateProfile(ID, Email, Name, Gender);
        }
        public static void changePassword(int ID, String NewPassword)
        {
            UserRepo.changePassword(ID, NewPassword);
        }
    }
}