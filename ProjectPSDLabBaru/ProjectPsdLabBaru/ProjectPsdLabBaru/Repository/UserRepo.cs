using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Constant;

namespace ProjectPsdLabBaru.Repository
{
    public class UserRepo
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static int getLastUserID()
        {
            if (db.Users.ToList().Count == 0) return 0;
            User user = db.Users.ToList().LastOrDefault();
            return user.ID;
        }
        public static User get(string email, string password)
        {
            User user = db.Users.Where(u =>
                    u.Email == email && u.Password == password
                )
                .FirstOrDefault();

            return user;
        }
        public static User get(int ID)
        {
            User user = db.Users.Where(u =>
                    u.ID == ID
                )
                .FirstOrDefault();

            return user;
        }
        public static User get(string email)
        {
            User user = db.Users.Where(u =>
                    u.Email == email
                )
                .FirstOrDefault();

            return user;
        }
        public static User getAnotherUser(int ID, String Email)
        {
            User user = db.Users.Where(u =>
                    u.Email == Email && u.ID != ID
                )
                .FirstOrDefault();

            return user;
        }
        public static String getUserStatus(string email, string password)
        {
            User currentUser = get(email, password);
            return currentUser.Status;
        }
        public static String getUserPassword(string email, string password)
        {
            User currentUser = get(email, password);
            return currentUser.Password;
        }
        public static void addUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public static List<User> getAllUser()
        {
            return db.Users.ToList();
        }
        public static List<UserInformation> getUserCustomView()
        {
            var UserInformation_List = (from x in db.Users
                                        join y in db.Roles on
                                        x.RoleID equals y.ID
                                        select new UserInformation { ID = x.ID, Name = x.Name, Role = y.Name, Status = x.Status }).ToList();
            return UserInformation_List;
        }
        public static int getRoleID(String Role)
        {
            Role role = (from x in db.Roles
                         where x.Name == Role
                         select x).FirstOrDefault();
            return role.ID;
        }
        public static void updateUser(int ID, String Role, String Status)
        {
            User userInfo = (from x in db.Users
                             where x.ID == ID
                             select x).FirstOrDefault();
            userInfo.RoleID = getRoleID(Role);
            userInfo.Status = Status;
            db.SaveChanges();
        }
        public static void updateProfile(int ID, String Email, String Name, String Gender)
        {
            User userInfo = (from x in db.Users
                             where x.ID == ID
                             select x
                                    ).FirstOrDefault();
            userInfo.Email = Email;
            userInfo.Name = Name;
            userInfo.Gender = Gender;
            db.SaveChanges();
        }
        public static void changePassword(int ID, String NewPassword)
        {
            User userInfo = (from x in db.Users
                             where x.ID == ID
                             select x
                                    ).FirstOrDefault();
            userInfo.Password = NewPassword;
            db.SaveChanges();
        }
    }
}