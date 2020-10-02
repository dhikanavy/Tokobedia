using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Factory
{
    public class UserFactory
    {
        public static User createUser(String email, String name, String password, String gender)
        {
            User user = new User();
            user.ID = UserHandler.getLastUserID()+1;
            user.RoleID = 2;
            user.Name = name;
            user.Email = email;
            user.Password = password;
            user.Gender = gender;
            user.Status = "active";
            return user;
        }
    }
}